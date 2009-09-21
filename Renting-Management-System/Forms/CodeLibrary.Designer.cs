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
            this.Certificatetype = new System.Windows.Forms.Button();
            this.Imagetype = new System.Windows.Forms.Button();
            this.customertype = new System.Windows.Forms.Button();
            this.usertype = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Add_btn = new System.Windows.Forms.Button();
            this.Del_btn = new System.Windows.Forms.Button();
            this.Mod_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            this.splitContainer1.Panel1.Controls.Add(this.Mod_btn);
            this.splitContainer1.Panel1.Controls.Add(this.Del_btn);
            this.splitContainer1.Panel1.Controls.Add(this.Add_btn);
            this.splitContainer1.Panel1.Controls.Add(this.Certificatetype);
            this.splitContainer1.Panel1.Controls.Add(this.Imagetype);
            this.splitContainer1.Panel1.Controls.Add(this.customertype);
            this.splitContainer1.Panel1.Controls.Add(this.usertype);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBox2);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(573, 264);
            this.splitContainer1.SplitterDistance = 147;
            this.splitContainer1.TabIndex = 0;
            // 
            // Certificatetype
            // 
            this.Certificatetype.Location = new System.Drawing.Point(0, 90);
            this.Certificatetype.Name = "Certificatetype";
            this.Certificatetype.Size = new System.Drawing.Size(75, 23);
            this.Certificatetype.TabIndex = 3;
            this.Certificatetype.Text = "证件类代码库";
            this.Certificatetype.UseVisualStyleBackColor = true;
            this.Certificatetype.Click += new System.EventHandler(this.Certificatetype_Click);
            // 
            // Imagetype
            // 
            this.Imagetype.Location = new System.Drawing.Point(0, 61);
            this.Imagetype.Name = "Imagetype";
            this.Imagetype.Size = new System.Drawing.Size(75, 23);
            this.Imagetype.TabIndex = 2;
            this.Imagetype.Text = "影像类代码库";
            this.Imagetype.UseVisualStyleBackColor = true;
            this.Imagetype.Click += new System.EventHandler(this.Imagetype_Click);
            // 
            // customertype
            // 
            this.customertype.Location = new System.Drawing.Point(0, 32);
            this.customertype.Name = "customertype";
            this.customertype.Size = new System.Drawing.Size(75, 23);
            this.customertype.TabIndex = 1;
            this.customertype.Text = "客户类代码库";
            this.customertype.UseVisualStyleBackColor = true;
            this.customertype.Click += new System.EventHandler(this.customertype_Click);
            // 
            // usertype
            // 
            this.usertype.Location = new System.Drawing.Point(3, 3);
            this.usertype.Name = "usertype";
            this.usertype.Size = new System.Drawing.Size(75, 23);
            this.usertype.TabIndex = 0;
            this.usertype.Text = "用户类代码库";
            this.usertype.UseVisualStyleBackColor = true;
            this.usertype.Click += new System.EventHandler(this.usertype_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(419, 218);
            this.dataGridView1.TabIndex = 0;
            // 
            // Add_btn
            // 
            this.Add_btn.Location = new System.Drawing.Point(0, 171);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(75, 23);
            this.Add_btn.TabIndex = 4;
            this.Add_btn.Text = "添加";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Del_btn
            // 
            this.Del_btn.Location = new System.Drawing.Point(3, 200);
            this.Del_btn.Name = "Del_btn";
            this.Del_btn.Size = new System.Drawing.Size(75, 23);
            this.Del_btn.TabIndex = 5;
            this.Del_btn.Text = "删除";
            this.Del_btn.UseVisualStyleBackColor = true;
            this.Del_btn.Click += new System.EventHandler(this.Del_btn_Click);
            // 
            // Mod_btn
            // 
            this.Mod_btn.Location = new System.Drawing.Point(0, 229);
            this.Mod_btn.Name = "Mod_btn";
            this.Mod_btn.Size = new System.Drawing.Size(75, 23);
            this.Mod_btn.TabIndex = 6;
            this.Mod_btn.Text = "修改";
            this.Mod_btn.UseVisualStyleBackColor = true;
            this.Mod_btn.Click += new System.EventHandler(this.Mod_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "代码编号";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "代码名称";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(279, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 4;
            // 
            // CodeLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 264);
            this.Controls.Add(this.splitContainer1);
            this.Name = "CodeLibrary";
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}