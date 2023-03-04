namespace L7_AVL_Tree
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFindAll = new System.Windows.Forms.Button();
            this.btnForEach = new System.Windows.Forms.Button();
            this.btnCheckForAll = new System.Windows.Forms.Button();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.btnExists = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.tbAdd = new System.Windows.Forms.TextBox();
            this.tbRemove = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.treeViewArray = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.treeViewLinked = new System.Windows.Forms.TreeView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tvUtils = new System.Windows.Forms.TreeView();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFindAll);
            this.panel1.Controls.Add(this.btnForEach);
            this.panel1.Controls.Add(this.btnCheckForAll);
            this.panel1.Controls.Add(this.tbFind);
            this.panel1.Controls.Add(this.btnExists);
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.tbAdd);
            this.panel1.Controls.Add(this.tbRemove);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 348);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1132, 107);
            this.panel1.TabIndex = 5;
            // 
            // btnFindAll
            // 
            this.btnFindAll.Location = new System.Drawing.Point(977, 33);
            this.btnFindAll.Name = "btnFindAll";
            this.btnFindAll.Size = new System.Drawing.Size(117, 49);
            this.btnFindAll.TabIndex = 15;
            this.btnFindAll.Text = "Utils Test Find All";
            this.btnFindAll.UseVisualStyleBackColor = true;
            this.btnFindAll.Click += new System.EventHandler(this.btnFindAll_Click);
            // 
            // btnForEach
            // 
            this.btnForEach.Location = new System.Drawing.Point(854, 33);
            this.btnForEach.Name = "btnForEach";
            this.btnForEach.Size = new System.Drawing.Size(117, 51);
            this.btnForEach.TabIndex = 14;
            this.btnForEach.Text = "Utils Test For Each";
            this.btnForEach.UseVisualStyleBackColor = true;
            this.btnForEach.Click += new System.EventHandler(this.btnForEach_Click);
            // 
            // btnCheckForAll
            // 
            this.btnCheckForAll.Location = new System.Drawing.Point(731, 33);
            this.btnCheckForAll.Name = "btnCheckForAll";
            this.btnCheckForAll.Size = new System.Drawing.Size(117, 51);
            this.btnCheckForAll.TabIndex = 13;
            this.btnCheckForAll.Text = "Utils Test Check For All";
            this.btnCheckForAll.UseVisualStyleBackColor = true;
            this.btnCheckForAll.Click += new System.EventHandler(this.btnCheckForAll_Click);
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(316, 66);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(106, 22);
            this.tbFind.TabIndex = 12;
            this.tbFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbFind_KeyDown);
            // 
            // btnExists
            // 
            this.btnExists.Location = new System.Drawing.Point(619, 33);
            this.btnExists.Name = "btnExists";
            this.btnExists.Size = new System.Drawing.Size(106, 51);
            this.btnExists.TabIndex = 11;
            this.btnExists.Text = "Utils Test Exist";
            this.btnExists.UseVisualStyleBackColor = true;
            this.btnExists.Click += new System.EventHandler(this.btnUtilsExists_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(316, 22);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(106, 38);
            this.btnFind.TabIndex = 10;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // tbAdd
            // 
            this.tbAdd.Location = new System.Drawing.Point(60, 64);
            this.tbAdd.Name = "tbAdd";
            this.tbAdd.Size = new System.Drawing.Size(106, 22);
            this.tbAdd.TabIndex = 9;
            this.tbAdd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAdd_KeyDown);
            // 
            // tbRemove
            // 
            this.tbRemove.Location = new System.Drawing.Point(183, 65);
            this.tbRemove.Name = "tbRemove";
            this.tbRemove.Size = new System.Drawing.Size(108, 22);
            this.tbRemove.TabIndex = 8;
            this.tbRemove.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbRemove_KeyDown);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(60, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 38);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(183, 20);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(108, 39);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(475, 31);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(106, 51);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 348);
            this.splitter1.TabIndex = 8;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(1129, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 348);
            this.splitter2.TabIndex = 9;
            this.splitter2.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(10, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1119, 348);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1111, 319);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ArrayTree";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.treeViewArray);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1105, 313);
            this.panel2.TabIndex = 7;
            // 
            // treeViewArray
            // 
            this.treeViewArray.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewArray.Location = new System.Drawing.Point(0, 0);
            this.treeViewArray.Name = "treeViewArray";
            this.treeViewArray.Size = new System.Drawing.Size(1105, 313);
            this.treeViewArray.TabIndex = 1;
            this.treeViewArray.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewArray_AfterSelect);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1111, 319);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "LinkedTree";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.treeViewLinked);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1105, 313);
            this.panel3.TabIndex = 8;
            // 
            // treeViewLinked
            // 
            this.treeViewLinked.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewLinked.Location = new System.Drawing.Point(0, 0);
            this.treeViewLinked.Name = "treeViewLinked";
            this.treeViewLinked.Size = new System.Drawing.Size(1105, 313);
            this.treeViewLinked.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel4);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1111, 319);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "TestUtilsTree";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tvUtils);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1105, 313);
            this.panel4.TabIndex = 11;
            // 
            // tvUtils
            // 
            this.tvUtils.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvUtils.Location = new System.Drawing.Point(0, 0);
            this.tvUtils.Name = "tvUtils";
            this.tvUtils.Size = new System.Drawing.Size(1105, 313);
            this.tvUtils.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 455);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbAdd;
        private System.Windows.Forms.TextBox tbRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnExists;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView treeViewArray;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TreeView treeViewLinked;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TreeView tvUtils;
        private System.Windows.Forms.Button btnForEach;
        private System.Windows.Forms.Button btnCheckForAll;
        private System.Windows.Forms.Button btnFindAll;
    }
}

