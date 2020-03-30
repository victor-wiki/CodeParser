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

        private void LoadTree()
        {
            if (!File.Exists(this.txtFile.Text))
            {
                return;
            }

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

            TreeNode rootNode = new TreeNode(info.EntryRuleName);
            rootNode.Tag = value;

            this.tvParserNodes.Nodes.Add(rootNode);

            this.AddChildNodes(rootNode, false);

            this.tvParserNodes.ExpandAll();

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

                list.AddRange(values);
            }
            else
            {
                list.Add(value);
            }

            bool hideEmptyNode = this.chkHideEmptyNode.Checked;

            foreach (object v in list)
            {
                Type t = v.GetType();
                MethodInfo[] methods = t.GetMethods();

                Regex regex = new Regex("[a-z]");

                foreach (MethodInfo m in methods)
                {
                    if (m.IsPublic && regex.IsMatch(m.Name[0].ToString()) && !m.Name.StartsWith("get") && !m.Name.StartsWith("set") && m.GetParameters().Length == 0)
                    {
                        var childValue = m.Invoke(v, new object[] { });

                        if (childValue == null && hideEmptyNode)
                        {
                            continue;
                        }

                        bool isArray = m.ReturnType.IsArray;
                        string count = "";

                        if (isArray)
                        {
                            count = childValue.GetType().GetMethod("get_Length").Invoke(childValue, new object[] { }).ToString();

                            if (count == "0" && hideEmptyNode)
                            {
                                continue;
                            }
                        }

                        string nodeText = isArray ? (m.Name + $"[{count}]") : m.Name;
                        TreeNode childNode = new TreeNode(nodeText);

                        childNode.Tag = childValue;

                        node.Nodes.Add(childNode);

                        this.AddChildNodes(childNode, false);
                    }
                }
            }

            if (expand)
            {
                node.Expand();
            }
        }

        private void txtFile_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.LoadTree();
            }
        }

        private void tvParserNodes_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            object value = e.Node.Tag;

            if (value == null)
            {
                return;
            }

            this.txtTypeName.Text = "";
            this.txtChildCount.Text = "";
            this.txtText.Text = "";

            Type type = value.GetType();

            this.txtTypeName.Text = type.Name;

            if (!type.IsArray)
            {
                var info = this.GetNodeValueInfo(value);
                this.txtChildCount.Text = info.ChildCount;
                this.txtText.Text = info.Text;
            }
            else
            {
                object[] values = value as object[];
                this.txtChildCount.Text = values.Length.ToString();
                this.txtText.Text = string.Join(Environment.NewLine, values.Select(item => this.GetNodeValueInfo(item).Text));
            }
        }

        private (string ChildCount, string Text) GetNodeValueInfo(object value)
        {
            Type type = value.GetType();
            var children = type.GetField("children").GetValue(value);
            string childCount = children.GetType().GetMethod("get_Count").Invoke(children, new object[] { }).ToString();
            string text = type.GetMethod("GetText").Invoke(value, new object[] { }).ToString();

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
    }
}
