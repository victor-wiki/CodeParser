namespace CodeParser.Viewer
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvParserNodes = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiExpandAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCollapseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.txtChildCount = new System.Windows.Forms.TextBox();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboParser = new System.Windows.Forms.ComboBox();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.chkHideEmptyNode = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(3, 42);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvParserNodes);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtChildCount);
            this.splitContainer1.Panel2.Controls.Add(this.txtTypeName);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.txtText);
            this.splitContainer1.Size = new System.Drawing.Size(832, 503);
            this.splitContainer1.SplitterDistance = 418;
            this.splitContainer1.TabIndex = 0;
            // 
            // tvParserNodes
            // 
            this.tvParserNodes.ContextMenuStrip = this.contextMenuStrip1;
            this.tvParserNodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvParserNodes.Location = new System.Drawing.Point(0, 0);
            this.tvParserNodes.Name = "tvParserNodes";
            this.tvParserNodes.Size = new System.Drawing.Size(418, 503);
            this.tvParserNodes.TabIndex = 0;
            this.tvParserNodes.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvParserNodes_NodeMouseClick);
            this.tvParserNodes.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvParserNodes_NodeMouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExpandAll,
            this.tsmiCollapseAll});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 48);
            // 
            // tsmiExpandAll
            // 
            this.tsmiExpandAll.Name = "tsmiExpandAll";
            this.tsmiExpandAll.Size = new System.Drawing.Size(141, 22);
            this.tsmiExpandAll.Text = "expand all";
            this.tsmiExpandAll.Click += new System.EventHandler(this.tsmiExpandAll_Click);
            // 
            // tsmiCollapseAll
            // 
            this.tsmiCollapseAll.Name = "tsmiCollapseAll";
            this.tsmiCollapseAll.Size = new System.Drawing.Size(141, 22);
            this.tsmiCollapseAll.Text = "collapse all";
            this.tsmiCollapseAll.Click += new System.EventHandler(this.tsmiCollapseAll_Click);
            // 
            // txtChildCount
            // 
            this.txtChildCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChildCount.Location = new System.Drawing.Point(86, 37);
            this.txtChildCount.Name = "txtChildCount";
            this.txtChildCount.Size = new System.Drawing.Size(314, 21);
            this.txtChildCount.TabIndex = 6;
            // 
            // txtTypeName
            // 
            this.txtTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTypeName.Location = new System.Drawing.Point(86, 10);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(314, 21);
            this.txtTypeName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "Child count:";
            // 
            // txtText
            // 
            this.txtText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtText.Location = new System.Drawing.Point(2, 75);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(408, 425);
            this.txtText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Parser:";
            // 
            // cboParser
            // 
            this.cboParser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboParser.FormattingEnabled = true;
            this.cboParser.Location = new System.Drawing.Point(57, 9);
            this.cboParser.Name = "cboParser";
            this.cboParser.Size = new System.Drawing.Size(115, 20);
            this.cboParser.TabIndex = 2;
            // 
            // txtFile
            // 
            this.txtFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFile.Location = new System.Drawing.Point(235, 9);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(397, 21);
            this.txtFile.TabIndex = 3;
            this.txtFile.TextChanged += new System.EventHandler(this.txtFile_TextChanged);
            this.txtFile.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFile_KeyUp);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFile.Location = new System.Drawing.Point(638, 8);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(36, 23);
            this.btnOpenFile.TabIndex = 4;
            this.btnOpenFile.Text = "...";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "File:";
            // 
            // chkHideEmptyNode
            // 
            this.chkHideEmptyNode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkHideEmptyNode.AutoSize = true;
            this.chkHideEmptyNode.Checked = true;
            this.chkHideEmptyNode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHideEmptyNode.Location = new System.Drawing.Point(711, 12);
            this.chkHideEmptyNode.Name = "chkHideEmptyNode";
            this.chkHideEmptyNode.Size = new System.Drawing.Size(114, 16);
            this.chkHideEmptyNode.TabIndex = 7;
            this.chkHideEmptyNode.Text = "Hide empty node";
            this.chkHideEmptyNode.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 548);
            this.Controls.Add(this.chkHideEmptyNode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.cboParser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CodeParser viewer";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvParserNodes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboParser;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChildCount;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiExpandAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiCollapseAll;
        private System.Windows.Forms.CheckBox chkHideEmptyNode;
    }
}

