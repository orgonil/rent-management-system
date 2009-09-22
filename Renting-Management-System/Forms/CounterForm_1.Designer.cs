namespace Renting_Management_System.Forms
{
    partial class CounterForm_1
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
            this.components = new System.ComponentModel.Container();
            this._Rent_Management_SystemDataSet = new Renting_Management_System._Rent_Management_SystemDataSet();
            this.imageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageTableAdapter = new Renting_Management_System._Rent_Management_SystemDataSetTableAdapters.ImageTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.select_btn = new System.Windows.Forms.Button();
            this.inster_btn = new System.Windows.Forms.Button();
            this.deleter_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this._Rent_Management_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // _Rent_Management_SystemDataSet
            // 
            this._Rent_Management_SystemDataSet.DataSetName = "_Rent_Management_SystemDataSet";
            this._Rent_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imageBindingSource
            // 
            this.imageBindingSource.DataMember = "Image";
            this.imageBindingSource.DataSource = this._Rent_Management_SystemDataSet;
            // 
            // imageTableAdapter
            // 
            this.imageTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 64);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 27);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(49, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "用户编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(280, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "用户信息";
            // 
            // select_btn
            // 
            this.select_btn.Location = new System.Drawing.Point(437, 61);
            this.select_btn.Margin = new System.Windows.Forms.Padding(4);
            this.select_btn.Name = "select_btn";
            this.select_btn.Size = new System.Drawing.Size(97, 27);
            this.select_btn.TabIndex = 8;
            this.select_btn.Text = "查询";
            this.select_btn.UseVisualStyleBackColor = true;
            this.select_btn.Click += new System.EventHandler(this.select_btn_Click);
            // 
            // inster_btn
            // 
            this.inster_btn.Location = new System.Drawing.Point(493, 329);
            this.inster_btn.Margin = new System.Windows.Forms.Padding(4);
            this.inster_btn.Name = "inster_btn";
            this.inster_btn.Size = new System.Drawing.Size(99, 43);
            this.inster_btn.TabIndex = 9;
            this.inster_btn.Text = "插入";
            this.inster_btn.UseVisualStyleBackColor = true;
            this.inster_btn.Click += new System.EventHandler(this.inster_btn_Click);
            // 
            // deleter_btn
            // 
            this.deleter_btn.Location = new System.Drawing.Point(150, 328);
            this.deleter_btn.Margin = new System.Windows.Forms.Padding(4);
            this.deleter_btn.Name = "deleter_btn";
            this.deleter_btn.Size = new System.Drawing.Size(95, 44);
            this.deleter_btn.TabIndex = 10;
            this.deleter_btn.Text = "删除 ";
            this.deleter_btn.UseVisualStyleBackColor = true;
            this.deleter_btn.Click += new System.EventHandler(this.deleter_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(329, 329);
            this.update_btn.Margin = new System.Windows.Forms.Padding(4);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(99, 43);
            this.update_btn.TabIndex = 11;
            this.update_btn.Text = "更改";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(49, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "用户名称：";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(140, 104);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(184, 26);
            this.textBox2.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "性别:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "出生日期：";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(140, 145);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(184, 26);
            this.textBox3.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "用户类型：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "证件代码：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "联系方式：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(361, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "用户地址：";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(140, 226);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(184, 26);
            this.textBox5.TabIndex = 22;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(437, 114);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(90, 26);
            this.textBox6.TabIndex = 23;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(140, 269);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(184, 26);
            this.textBox7.TabIndex = 24;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(461, 159);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(162, 26);
            this.textBox8.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(361, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 16);
            this.label10.TabIndex = 26;
            this.label10.Text = "用户描述：";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(461, 206);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(164, 26);
            this.textBox9.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(361, 254);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "用户拒绝：";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(461, 249);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(162, 26);
            this.textBox10.TabIndex = 29;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(150, 190);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 30;
            // 
            // 柜台管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 415);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.deleter_btn);
            this.Controls.Add(this.inster_btn);
            this.Controls.Add(this.select_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "柜台管理";
            this.Text = "柜台管理";
            this.Load += new System.EventHandler(this.柜台管理_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Rent_Management_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _Rent_Management_SystemDataSet _Rent_Management_SystemDataSet;
        private System.Windows.Forms.BindingSource imageBindingSource;
        private Renting_Management_System._Rent_Management_SystemDataSetTableAdapters.ImageTableAdapter imageTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button select_btn;
        private System.Windows.Forms.Button inster_btn;
        private System.Windows.Forms.Button deleter_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.ComboBox comboBox1;

    }
}