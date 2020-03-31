using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace CodeParser.Viewer
{
    public partial class frmMain : Form
    {
        private string coderPaserDllName = "CodeParser.dll";
        private Assembly assembly = null;
        private List<Type> parserTypes = new List<Type>();
        private Parser parser = null;       

        private static List<string> ignoreMethods = new List<string>()
        {
            "getAltNumber",
            "Eof"
        };

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.InitControls();
        }

        private void InitControls()
        {
            this.LoadParsers();

            this.cboParser.SelectedIndex = -1;
        }

        private void LoadParsers()
        {
            this.assembly = Assembly.LoadFrom(this.coderPaserDllName);
            var typeArray = this.assembly.ExportedTypes;

            this.parserTypes = (from type in typeArray
                                where type.IsSubclassOf(typeof(Parser)) && !type.IsAbstract
                                orderby type.Name
                                select type).ToList();

            this.cboParser.DataSource = this.parserTypes;
            this.cboParser.DisplayMember = "Name";
            this.cboParser.ValueMember = "Name";
        }

        private Type GetLexerType(string name)
        {
            return (from type in this.assembly.ExportedTypes
                    where type.IsSubclassOf(typeof(Lexer)) && type.Name == name
                    orderby type.Name
                    select type).FirstOrDefault();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (this.cboParser.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a parser first.");
                return;
            }

            ParserInfo info = this.GetParserInfo();

            if (info == null)
            {
                return;
            }

            string extension = info.FileExtension;

            string filter = $"{info.Language} files|*{extension}|all files|*.*";

            this.openFileDialog1.FileName = "";
            this.openFileDialog1.Filter = filter;

            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txtFile.Text = this.openFileDialog1.FileName;

                this.LoadTree();
            }
        }

        private ParserInfo GetParserInfo()
        {
            string parserName = this.cboParser.Text;

            ParserInfo info = ParserManager.GetParserInfoByName(parserName);

            if (info == null)
            {
                MessageBox.Show($"Can't get ParserInfo for parser \"{parserName}\".");
                return null;
            }

            return info;
        }

        private void txtFile_TextChanged(object sender, EventArgs e)
        {
            this.LoadTree();
        }

        private void Reset()
        {
            this.txtChildCount.Text = "";
            this.txtTypeName.Text = "";
            this.txtText.Text = "";
        }

        private void LoadTree()
        {
            if (!File.Exists(this.txtFile.Text))
            {
                return;
            }

            this.Reset();

            this.tvParserNodes.Nodes.Clear();

            string parserName = this.cboParser.Text;

            Type parserType = this.parserTypes.FirstOrDefault(item => item.Name == parserName);

            Type lexerType = this.GetLexerType(parserType.Name.Replace("Parser", "Lexer"));

            Lexer lexer = (Lexer)Activator.CreateInstance(lexerType, new object[] { CharStreams.fromPath(this.txtFile.Text) });

            CommonTokenStream tokens = new CommonTokenStream(lexer);

            this.parser = (Parser)Activator.CreateInstance(parserType, new object[] { tokens });

            ParserInfo info = this.GetParserInfo();

            if (info == null)
            {
                return;
            }

            MethodInfo rootMethod = parserType.GetMethod(info.EntryRuleName);

            object value = rootMethod.Invoke(parser, new object[] { });

            TreeNode rootNode = this.CreateTreeNode(info.EntryRuleName);
            rootNode.Tag = value;

            this.tvParserNodes.Nodes.Add(rootNode);

            this.AddChildNodes(rootNode, false);

            rootNode.Expand();

            rootNode.EnsureVisible();
        }

        private void AddChildNodes(TreeNode node, bool expand)
        {
            object value = node.Tag;

            if (value == null)
            {
                return;
            }

            List<object> list = new List<object>();

            Type type = value.GetType();

            if (type.IsArray)
            {
                object[] values = value as object[];

                if (values != null)
                {
                    list.AddRange(values);
                }
                else
                {
                    list.Add(value);
                }
            }
            else
            {
                list.Add(value);
            }

            bool hideEmptyNode = this.chkHideEmptyNode.Checked;

            foreach (object v in list)
            {
                Type t = v.GetType();

                if (this.rbMethods.Checked)
                {
                    #region Methods                 

                    MethodInfo[] methods = t.GetMethods();

                    foreach (MethodInfo m in methods)
                    {
                        if (m.IsPublic && !ignoreMethods.Contains(m.Name) && m.Module.Name == this.coderPaserDllName && !m.Name.StartsWith("get_") && !m.Name.StartsWith("set_") && m.GetParameters().Length == 0)
                        {
                            var childValue = m.Invoke(v, new object[] { });

                            if (childValue == null && hideEmptyNode)
                            {
                                continue;
                            }

                            bool isArray = m.ReturnType.IsArray;
                            int count = 0;

                            if (isArray && childValue is IEnumerable<IParseTree> treeNodes)
                            {
                                count = treeNodes.Count();

                                if (count == 0 && hideEmptyNode)
                                {
                                    continue;
                                }
                            }

                            string nodeText = isArray ? (m.Name + "[]") : m.Name;
                            TreeNode childNode = this.CreateTreeNode(nodeText);

                            childNode.Tag = childValue;                            

                            node.Nodes.Add(childNode);

                            Console.WriteLine(m.Name);

                            this.AddChildNodes(childNode, false);
                        }
                    }

                    #endregion
                }

                if (this.rbChildren.Checked)
                {
                    #region Children          

                    var childrenField = type.GetField("children");

                    if (childrenField != null)
                    {
                        var children = childrenField.GetValue(value);

                        if (children != null)
                        {
                            if (children is List<IParseTree> treeNodes)
                            {
                                int i = 0;

                                foreach (IParseTree tn in treeNodes)
                                {
                                    TreeNode childNode = this.CreateTreeNode($"{tn.GetType().Name}");
                                    childNode.Tag = tn;

                                    node.Nodes.Add(childNode);

                                    this.AddChildNodes(childNode, false);

                                    i++;
                                }
                            }
                        }
                    }

                    #endregion
                }
            }

            if (expand)
            {
                node.Expand();
            }
        }       

        private TreeNode CreateTreeNode(string text, string imageKey = null)
        {
            TreeNode node = new TreeNode(text);
            node.ImageKey = string.IsNullOrEmpty(imageKey) ? "" : imageKey;
            node.SelectedImageKey = node.ImageKey;

            return node;
        }

        private void txtFile_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.LoadTree();
            }
        }

        private (int ChildCount, string Text) GetNodeValueInfo(object value)
        {
            Type type = value.GetType();

            int childCount = 0;
            string text = "";

            if (type.IsClass)
            {
                var childrenField = type.GetField("children");

                if (childrenField != null)
                {
                    var children = childrenField.GetValue(value);

                    if (children != null)
                    {
                        if (children is List<IParseTree> treeNodes)
                        {
                            childCount = treeNodes.Count;

                            if (childCount > 1)
                            {
                                text = string.Join(" ", treeNodes.Select(item => item.GetText()));
                            }
                            else if (childCount == 1)
                            {
                                text = this.GetNodeValueInfo(treeNodes[0]).Text;
                            }
                        }
                        else
                        {
                            childCount = int.Parse(children.GetType().GetMethod("get_Count").Invoke(children, new object[] { }).ToString());
                        }
                    }
                }
            }

            if (this.tvParserNodes.SelectedNode != null && this.tvParserNodes.SelectedNode.Level == 0 && this.tvParserNodes.Nodes.Count == 1)
            {
                text = this.GetFileContent();
            }
            else
            {
                if (string.IsNullOrEmpty(text))
                {
                    text = type.GetMethod("GetText").Invoke(value, new object[] { }).ToString();
                }
            }

            return (childCount, text);
        }

        private void tvParserNodes_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Nodes.Count > 0)
            {
                return;
            }

            this.AddChildNodes(e.Node, true);
        }

        private void tsmiExpandAll_Click(object sender, EventArgs e)
        {
            this.tvParserNodes.ExpandAll();
        }

        private void tsmiCollapseAll_Click(object sender, EventArgs e)
        {
            this.tvParserNodes.CollapseAll();
        }

        private void tvParserNodes_AfterSelect(object sender, TreeViewEventArgs e)
        {
            object value = e.Node.Tag;

            if (value == null)
            {
                return;
            }

            this.Reset();

            Type type = value.GetType();

            this.txtTypeName.Text = type.Name;

            if (!type.IsArray)
            {
                var info = this.GetNodeValueInfo(value);
                this.txtChildCount.Text = info.ChildCount.ToString();
                this.txtText.Text = info.Text;
            }
            else
            {
                object[] values = value as object[];
                this.txtChildCount.Text = values.Length.ToString();
                this.txtText.Text = string.Join(Environment.NewLine, values.Select(item => this.GetNodeValueInfo(item).Text));
            }
        }

        private string GetFileContent()
        {
            string filePath = this.txtFile.Text;

            if (File.Exists(filePath))
            {
                return File.ReadAllText(filePath);
            }

            return string.Empty;
        }

        private void frmMain_DragDrop(object sender, DragEventArgs e)
        {
            this.SetDropFiles(e);
        }

        private void frmMain_DragOver(object sender, DragEventArgs e)
        {
            this.SetDragEffect(e);
        }

        private void SetDragEffect(DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void SetDropFiles(DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] filePaths = (string[])e.Data.GetData(DataFormats.FileDrop.ToString());

                string filePath = filePaths.FirstOrDefault();

                if (!string.IsNullOrEmpty(filePath) && filePath != this.txtFile.Text)
                {
                    this.txtFile.Text = filePath;

                    this.LoadTree();
                }
            }
        }

        private void rbChildren_CheckedChanged(object sender, EventArgs e)
        {
            this.LoadTree();
        }

        private void rbMethods_CheckedChanged(object sender, EventArgs e)
        {
            this.LoadTree();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            this.LoadTree();
        }
    }
}
