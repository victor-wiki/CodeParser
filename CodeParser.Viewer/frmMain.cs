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
        private Color selectionBackColor = ColorTranslator.FromHtml("#0078D7");
        private Dictionary<TreeNode, TokenInfo> dictTokenInfo = new Dictionary<TreeNode, TokenInfo>();

        private static List<string> ignoreMethods = new List<string>()
        {
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

        private bool IsSqlParser()
        {
            string parserName = this.cboParser.Text;

            if(!string.IsNullOrEmpty(parserName))
            {               
                if(parserName == nameof(MySqlParser) ||
                   parserName == nameof(TSqlParser) ||
                   parserName == nameof(PlSqlParser) ||
                   parserName == nameof(SQLiteParser)
                  )
                {
                    return true;
                }
            }
            return false;
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

        private void LoadFromFile()
        {
            string content= this.GetFileContent();
            this.txtText.Text = this.IsSqlParser() ? content.ToUpper() : content;
            this.LoadTree();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            this.SelectFile();
        }

        private void SelectFile()
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

                this.LoadFromFile();
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
            if (File.Exists(this.txtFile.Text))
            {
                this.LoadFromFile();
            }
        }

        private void ClearValues()
        {
            this.txtChildCount.Text = "";
            this.txtTypeName.Text = "";

            this.ClearSelection();
        }

        private void ClearSelection()
        {
            int start = this.txtText.SelectionStart;

            this.txtText.SelectAll();
            this.txtText.SelectionBackColor = Color.White;
            this.txtText.SelectionColor = Color.Black;
            this.txtText.SelectionStart = start;
            this.txtText.SelectionLength = 0;
        }

        private void LoadTree()
        {
            this.ClearValues();
            this.txtMessage.Text = "";

            this.tvParserNodes.Nodes.Clear();
            this.dictTokenInfo.Clear();

            if (this.cboParser.SelectedIndex < 0)
            {
                return;
            }

            if (string.IsNullOrEmpty(this.txtText.Text))
            {
                return;
            }

            string parserName = this.cboParser.Text;

            Type parserType = this.parserTypes.FirstOrDefault(item => item.Name == parserName);

            Type lexerType = this.GetLexerType(parserType.Name.Replace("Parser", "Lexer"));

            Lexer lexer = (Lexer)Activator.CreateInstance(lexerType, new object[] { CharStreams.fromstring(this.txtText.Text) });

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
                        if (m.IsPublic && !m.IsSpecialName && !ignoreMethods.Contains(m.Name) && m.Module.Name == this.coderPaserDllName && m.GetParameters().Length == 0)
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
                            childNode.Name = m.Name;

                            childNode.Tag = childValue;

                            node.Nodes.Add(childNode);

                            this.dictTokenInfo.Add(childNode, this.GetTokenInfo(childValue));

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
                                    if (tn is TerminalNodeImpl && tn.GetText() == "<EOF>" && this.chkHideEmptyNode.Checked)
                                    {
                                        continue;
                                    }

                                    string childName = tn.GetType().Name;

                                    TreeNode childNode = this.CreateTreeNode($"{childName}");
                                    childNode.Name = childName;
                                    childNode.Tag = tn;

                                    if(tn is ErrorNodeImpl)
                                    {
                                        childNode.ForeColor = Color.Red;
                                    }

                                    node.Nodes.Add(childNode);

                                    this.dictTokenInfo.Add(childNode, this.GetTokenInfo(tn));

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
                this.LoadFromFile();
            }
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
            TreeNode node = this.tvParserNodes.SelectedNode;

            this.tvParserNodes.ExpandAll();

            if (node != null)
            {
                node.EnsureVisible();
            }
        }

        private void tsmiCollapseAll_Click(object sender, EventArgs e)
        {
            this.tvParserNodes.CollapseAll();
        }

        private void tvParserNodes_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.ShowNodeDetails(e.Node);
        }

        private void ShowNodeDetails(TreeNode node)
        {
            if (this.tvParserNodes.SelectedNode != null && this.tvParserNodes.SelectedNode.Level == 0 && this.tvParserNodes.Nodes.Count == 1)
            {
                return;
            }

            this.ClearValues();
            this.ClearSelection();

            object value = node.Tag;

            if (value == null)
            {
                return;
            }

            Type type = value.GetType();
            this.txtTypeName.Text = type.Name;

            TokenInfo tokenInfo = this.GetTokenInfo(value);

            this.txtChildCount.Text = tokenInfo.ChildCount?.ToString();

            if (!tokenInfo.StartIndex.HasValue || tokenInfo.StartIndex < 0 || !tokenInfo.StopIndex.HasValue || tokenInfo.StopIndex < 0)
            {
                return;
            }

            int length = tokenInfo.StopIndex.Value - tokenInfo.StartIndex.Value + 1;

            if (length > 0)
            {
                this.txtText.SelectionStart = tokenInfo.StartIndex.Value;
                this.txtText.SelectionLength = length;
                this.txtText.SelectionBackColor = this.selectionBackColor;
                this.txtText.SelectionColor = Color.White;

                this.txtText.ScrollToCaret();
            }

            this.txtMessage.Text = this.GetTreeNodePath(node);
        }

        private TokenInfo GetTokenInfo(dynamic value)
        {
            TokenInfo tokenInfo = new TokenInfo();

            if (value is ParserRuleContext context)
            {
                tokenInfo.StartIndex = context.Start?.StartIndex;
                tokenInfo.StopIndex = context.Stop?.StopIndex;
                tokenInfo.ChildCount = context.children?.Count;
            }
            else if (value is ParserRuleContext[] contextes)
            {
                if (contextes.Any())
                {
                    tokenInfo.StartIndex = contextes.First().Start?.StartIndex;
                    tokenInfo.StopIndex = contextes.Last().Stop?.StopIndex;
                    tokenInfo.ChildCount = contextes.Length;
                }
            }
            else if (value is ITerminalNode terminalNode)
            {
                tokenInfo.StartIndex = terminalNode.Symbol?.StartIndex;
                tokenInfo.StopIndex = terminalNode.Symbol?.StopIndex;
                tokenInfo.ChildCount = terminalNode.ChildCount;
            }
            else if (value is ITerminalNode[] terminalNodes)
            {
                if (terminalNodes.Any())
                {
                    tokenInfo.StartIndex = terminalNodes.First().Symbol?.StartIndex;
                    tokenInfo.StopIndex = terminalNodes.Last().Symbol?.StopIndex;
                    tokenInfo.ChildCount = terminalNodes.Length;
                }
            }

            return tokenInfo;
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

                    this.LoadFromFile();
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
            if (File.Exists(this.txtFile.Text))
            {
                this.LoadFromFile();
            }
            else
            {
                this.LoadTree();
            }
        }

        private void tvParserNodes_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.tvParserNodes.SelectedNode = e.Node;

                this.SetMenuItemVisible(e.Node);

                this.treeContextMenu.Show(Cursor.Position);
            }
        }

        private void SetMenuItemVisible(TreeNode node)
        {
            this.tsmiCollapseToChildren.Visible = node != null;
            this.tsmiCopyPath.Visible = node != null;
        }

        private void tvParserNodes_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && this.tvParserNodes.SelectedNode == null)
            {
                this.SetMenuItemVisible(null);

                this.treeContextMenu.Show(Cursor.Position);
            }
        }

        private void tsmiCollapseToChildren_Click(object sender, EventArgs e)
        {
            TreeNode node = this.tvParserNodes.SelectedNode;

            if (node != null)
            {
                node.Collapse(false);
            }
        }

        private string GetTreeNodePath(TreeNode node)
        {
            List<string> texts = new List<string>();

            texts.Add(string.IsNullOrEmpty(node.Name) ? node.Text : node.Name);

            TreeNode parent = node.Parent;
            while (parent != null)
            {
                texts.Add(string.IsNullOrEmpty(parent.Name) ? parent.Text : parent.Name);
                parent = parent.Parent;
            }

            texts.Reverse();

            return string.Join(" > ", texts);
        }

        private void tsmiCopyPath_Click(object sender, EventArgs e)
        {
            this.CopyNodeText(true);
        }

        private void tsmiCopyText_Click(object sender, EventArgs e)
        {
            this.CopyNodeText(false);
        }

        private void CopyNodeText(bool isCopyPath)
        {
            TreeNode node = this.tvParserNodes.SelectedNode;

            if (node != null)
            {
                if (isCopyPath)
                {
                    string path = this.GetTreeNodePath(node);

                    if (!string.IsNullOrEmpty(path))
                    {
                        Clipboard.SetDataObject(path);
                    }
                }
                else
                {
                    Clipboard.SetDataObject(node.Text);
                }

                MessageBox.Show("Has been copied to clipboard.");

                this.tvParserNodes.SelectedNode = node;
            }
        }

        private void tsmiExpandAllChildren_Click(object sender, EventArgs e)
        {
            TreeNode node = this.tvParserNodes.SelectedNode;

            if (node != null)
            {
                node.ExpandAll();
                node.EnsureVisible();
            }
        }

        private void txtMessage_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.txtMessage.SelectAll();
        }

        private void txtFile_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.SelectFile();
        }       

        private void tsmiPaste_Click(object sender, EventArgs e)
        {
            var data = Clipboard.GetDataObject();
            if (data != null)
            {
                this.txtText.Text = data.GetData(DataFormats.UnicodeText)?.ToString();

                this.LoadTree();
            }
        }

        private void cboParser_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadTree();
        }

        private void tsmiClearSelection_Click(object sender, EventArgs e)
        {
            this.ClearSelection();
        }

        private void tsmiNavigateToTreeNode_Click(object sender, EventArgs e)
        {
            if (this.txtText.SelectionLength > 0)
            {
                int start = this.txtText.SelectionStart + (this.txtText.SelectedText.Length - this.txtText.SelectedText.TrimStart().Length);
                int length = this.txtText.SelectedText.Trim().Replace("\n", "").Length;

                TreeNode node = this.FindTreeNode(start, length);

                if (node != null)
                {
                    this.tvParserNodes.SelectedNode = node;

                    node.EnsureVisible();
                }
                else
                {
                    MessageBox.Show("No match.");
                }
            }
        }

        private TreeNode FindTreeNode(int start, int lenght)
        {
            int end = start + lenght - 1;

            TreeNode node = this.dictTokenInfo
                    .Where(item => item.Value.StartIndex.HasValue && item.Value.StopIndex.HasValue && start >= item.Value.StartIndex && end <= item.Value.StopIndex)
                    .OrderByDescending(item => item.Key.Level)
                    .Select(item => item.Key)
                    .FirstOrDefault();

            return node;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Reset();
        }

        private void Reset()
        {
            this.cboParser.SelectedIndex = -1;
            this.txtFile.Text = "";
            this.ClearValues();
            this.tvParserNodes.Nodes.Clear();
            this.txtText.Text = "";
            this.txtMessage.Text = "";
        }

        private void txtText_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //this.tsmiClearSelection.Visible = this.txtText.SelectionLength > 0;
                this.tsmiNavigateToTreeNode.Visible = this.txtText.SelectionLength > 0;
                this.tsmiPaste.Visible = this.txtText.Text.Length == 0 || this.txtText.SelectionLength == this.txtText.Text.Length;

                this.textContextMenu.Show(this.txtText, e.Location);
            }
        }

        private void txtMessage_MouseEnter(object sender, EventArgs e)
        {
            this.toolTip1.SetToolTip(this.txtMessage, this.txtMessage.Text);
        }

        private void txtText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode == Keys.V)
                {
                    this.txtFile.Text = "";

                    if (this.IsSqlParser() && (this.txtText.Text.Length ==0 || this.txtText.SelectedText.Length == this.txtText.Text.Length))
                    {
                        e.SuppressKeyPress = true;

                        this.txtText.Clear();

                        string content = Clipboard.GetText();

                        this.txtText.AppendText(content.ToUpper());                       
                    }               

                    this.LoadTree();
                }
                else if (e.KeyCode.HasFlag(Keys.U))
                {
                    if (e.Shift)
                    {
                        this.txtText.SelectedText = this.txtText.SelectedText.ToUpper();

                        if (this.txtText.SelectionLength == this.txtText.TextLength)
                        {
                            this.LoadTree();
                        }
                    }
                    else
                    {
                        this.txtText.SelectedText = this.txtText.SelectedText.ToLower();
                    }
                }
            }
        }

        private void tsmiConvertToUpperCase_Click(object sender, EventArgs e)
        {
            this.txtText.Text = this.txtText.Text.ToUpper();
        }

        private void tsmiConvertToLowerCase_Click(object sender, EventArgs e)
        {
            this.txtText.Text = this.txtText.Text.ToLower();
        }

        private void txtText_SelectionChanged(object sender, EventArgs e)
        {
            this.txtText.SelectionFont = this.txtText.Font;
        }
    }
}
