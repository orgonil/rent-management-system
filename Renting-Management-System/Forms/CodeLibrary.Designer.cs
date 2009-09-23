namespace Renting_Management_System.Forms
{
    partial class CodeLibrary
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Mod_btn = new System.Windows.Forms.Button();
            this.Del_btn = new System.Windows.Forms.Button();
            this.Add_btn = new System.Windows.Forms.Button();
            this.Certificatetype = new System.Windows.Forms.Button();
            this.Imagetype = new System.Windows.Forms.Button();
            this.customertype = new System.Windows.Forms.Button();
            this.usertype = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Certificatetype);
            this.splitContainer1.Panel1.Controls.Add(this.Imagetype);
            this.splitContainer1.Panel1.Controls.Add(this.customertype);
            this.splitContainer1.Panel1.Controls.Add(this.usertype);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Del_btn);
            this.splitContainer1.Panel2.Controls.Add(this.Mod_btn);
            this.splitContainer1.Panel2.Controls.Add(this.txtName);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.Add_btn);
            this.splitContainer1.Panel2.Controls.Add(this.txtID);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
<<<<<<< .mine
            this.splitContainer1.Size = new System.Drawing.Size(573, 286);
            this.splitContainer1.SplitterDistance = 147;
=======
            this.splitContainer1.Size = new System.Drawing.Size(469, 264);
            this.splitContainer1.SplitterDistance = 92;
>>>>>>> .r63
            this.splitContainer1.TabIndex = 0;
            // 
            // Mod_btn
            // 
<<<<<<< .mine
            this.Mod_btn.Location = new System.Drawing.Point(10, 217);
=======
            this.Mod_btn.Location = new System.Drawing.Point(152, 53);
>>>>>>> .r63
            this.Mod_btn.Name = "Mod_btn";
            this.Mod_btn.Size = new System.Drawing.Size(75, 25);
            this.Mod_btn.TabIndex = 0;
            this.Mod_btn.Text = "修改";
            this.Mod_btn.Click += new System.EventHandler(this.Mod_btn_Click);
            // 
            // Del_btn
            // 
<<<<<<< .mine
            this.Del_btn.Location = new System.Drawing.Point(10, 248);
=======
            this.Del_btn.Location = new System.Drawing.Point(279, 53);
>>>>>>> .r63
            this.Del_btn.Name = "Del_btn";
            this.Del_btn.Size = new System.Drawing.Size(75, 25);
            this.Del_btn.TabIndex = 1;
            this.Del_btn.Text = "删除";
            this.Del_btn.Click += new System.EventHandler(this.Del_btn_Click);
            // 
            // Add_btn
            // 
<<<<<<< .mine
            this.Add_btn.Location = new System.Drawing.Point(10, 185);
=======
            this.Add_btn.Location = new System.Drawing.Point(18, 53);
>>>>>>> .r63
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(75, 25);
            this.Add_btn.TabIndex = 4;
            this.Add_btn.Text = "添加";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Certificatetype
            // 
<<<<<<< .mine
            this.Certificatetype.Location = new System.Drawing.Point(9, 102);
=======
            this.Certificatetype.Location = new System.Drawing.Point(8, 90);
>>>>>>> .r63
            this.Certificatetype.Name = "Certificatetype";
            this.Certificatetype.Size = new System.Drawing.Size(75, 25);
            this.Certificatetype.TabIndex = 3;
            this.Certificatetype.Text = "证件类代码库";
            this.Certificatetype.UseVisualStyleBackColor = true;
            this.Certificatetype.Click += new System.EventHandler(this.Certificatetype_Click);
            // 
            // Imagetype
            // 
<<<<<<< .mine
            this.Imagetype.Location = new System.Drawing.Point(10, 70);
=======
            this.Imagetype.Location = new System.Drawing.Point(9, 61);
>>>>>>> .r63
            this.Imagetype.Name = "Imagetype";
            this.Imagetype.Size = new System.Drawing.Size(75, 25);
            this.Imagetype.TabIndex = 2;
            this.Imagetype.Text = "影像类代码库";
            this.Imagetype.UseVisualStyleBackColor = true;
            this.Imagetype.Click += new System.EventHandler(this.Imagetype_Click);
            // 
            // customertype
            // 
<<<<<<< .mine
            this.customertype.Location = new System.Drawing.Point(9, 39);
=======
            this.customertype.Location = new System.Drawing.Point(9, 32);
>>>>>>> .r63
            this.customertype.Name = "customertype";
            this.customertype.Size = new System.Drawing.Size(75, 25);
            this.customertype.TabIndex = 1;
            this.customertype.Text = "客户类代码库";
            this.customertype.UseVisualStyleBackColor = true;
            this.customertype.Click += new System.EventHandler(this.customertype_Click);
            // 
            // usertype
            // 
<<<<<<< .mine
            this.usertype.Location = new System.Drawing.Point(10, 7);
=======
            this.usertype.Location = new System.Drawing.Point(9, 3);
>>>>>>> .r63
            this.usertype.Name = "usertype";
            this.usertype.Size = new System.Drawing.Size(75, 25);
            this.usertype.TabIndex = 0;
            this.usertype.Text = "用户类代码库";
            this.usertype.UseVisualStyleBackColor = true;
            this.usertype.Click += new System.EventHandler(this.usertype_Click);
            // 
<<<<<<< .mine
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 41);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(422, 25);
            this.bindingNavigator1.TabIndex = 5;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新添";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "删除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
=======
>>>>>>> .r63
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(279, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "代码名称";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(75, 13);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "代码编号";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
<<<<<<< .mine
            this.dataGridView1.Location = new System.Drawing.Point(0, 66);
=======
            this.dataGridView1.Location = new System.Drawing.Point(0, 82);
>>>>>>> .r63
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
<<<<<<< .mine
            this.dataGridView1.Size = new System.Drawing.Size(422, 220);
=======
            this.dataGridView1.Size = new System.Drawing.Size(373, 182);
>>>>>>> .r63
            this.dataGridView1.TabIndex = 0;
            // 
            // CodeLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< .mine
            this.ClientSize = new System.Drawing.Size(573, 286);
=======
            this.ClientSize = new System.Drawing.Size(469, 264);
>>>>>>> .r63
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CodeLibrary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "代码库";
            this.Load += new System.EventHandler(this.CodeLibrary_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button Certificatetype;
        private System.Windows.Forms.Button Imagetype;
        private System.Windows.Forms.Button customertype;
        private System.Windows.Forms.Button usertype;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Mod_btn;
        private System.Windows.Forms.Button Del_btn;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
    }
}