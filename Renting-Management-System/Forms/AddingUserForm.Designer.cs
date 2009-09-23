namespace Renting_Management_System.Forms
{
    partial class AddingUserForm
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
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.radioButton_DenyNo = new System.Windows.Forms.RadioButton();
            this.radioButton_DenyYes = new System.Windows.Forms.RadioButton();
            this.comboBox_UserType = new System.Windows.Forms.ComboBox();
            this.textBox_UserPassword02 = new System.Windows.Forms.TextBox();
            this.textBox_UserPassword01 = new System.Windows.Forms.TextBox();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.textBox_UserID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_CertificateType = new System.Windows.Forms.ComboBox();
            this.textBox_UserAddress = new System.Windows.Forms.TextBox();
            this.radioButton_SexGirl = new System.Windows.Forms.RadioButton();
            this.radioButton_SexBoy = new System.Windows.Forms.RadioButton();
            this.textBox_UserDescription = new System.Windows.Forms.TextBox();
            this.textBox_Contact = new System.Windows.Forms.TextBox();
            this.textBox_CertificateNumber = new System.Windows.Forms.TextBox();
            this.dateTimePicker_BirthDate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Add
            // 
            this.button_Add.Enabled = false;
            this.button_Add.Location = new System.Drawing.Point(403, 363);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 2;
            this.button_Add.Text = "添加";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(494, 363);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 3;
            this.button_Cancel.Text = "取消";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.radioButton_DenyNo);
            this.groupBox1.Controls.Add(this.radioButton_DenyYes);
            this.groupBox1.Controls.Add(this.comboBox_UserType);
            this.groupBox1.Controls.Add(this.textBox_UserPassword02);
            this.groupBox1.Controls.Add(this.textBox_UserPassword01);
            this.groupBox1.Controls.Add(this.textBox_UserName);
            this.groupBox1.Controls.Add(this.textBox_UserID);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 189);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用户登录信息：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(183, 157);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(190, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "注意： 上面所有的信息不能为空！";
            // 
            // radioButton_DenyNo
            // 
            this.radioButton_DenyNo.AutoSize = true;
            this.radioButton_DenyNo.Location = new System.Drawing.Point(470, 112);
            this.radioButton_DenyNo.Name = "radioButton_DenyNo";
            this.radioButton_DenyNo.Size = new System.Drawing.Size(37, 17);
            this.radioButton_DenyNo.TabIndex = 20;
            this.radioButton_DenyNo.Text = "否";
            this.radioButton_DenyNo.UseVisualStyleBackColor = true;
            // 
            // radioButton_DenyYes
            // 
            this.radioButton_DenyYes.AutoSize = true;
            this.radioButton_DenyYes.Checked = true;
            this.radioButton_DenyYes.Location = new System.Drawing.Point(395, 111);
            this.radioButton_DenyYes.Name = "radioButton_DenyYes";
            this.radioButton_DenyYes.Size = new System.Drawing.Size(37, 17);
            this.radioButton_DenyYes.TabIndex = 19;
            this.radioButton_DenyYes.TabStop = true;
            this.radioButton_DenyYes.Text = "是";
            this.radioButton_DenyYes.UseVisualStyleBackColor = true;
            // 
            // comboBox_UserType
            // 
            this.comboBox_UserType.FormattingEnabled = true;
            this.comboBox_UserType.Location = new System.Drawing.Point(101, 111);
            this.comboBox_UserType.Name = "comboBox_UserType";
            this.comboBox_UserType.Size = new System.Drawing.Size(174, 21);
            this.comboBox_UserType.TabIndex = 18;
            // 
            // textBox_UserPassword02
            // 
            this.textBox_UserPassword02.Location = new System.Drawing.Point(395, 71);
            this.textBox_UserPassword02.Name = "textBox_UserPassword02";
            this.textBox_UserPassword02.PasswordChar = '*';
            this.textBox_UserPassword02.Size = new System.Drawing.Size(174, 20);
            this.textBox_UserPassword02.TabIndex = 17;
            // 
            // textBox_UserPassword01
            // 
            this.textBox_UserPassword01.Location = new System.Drawing.Point(101, 71);
            this.textBox_UserPassword01.Name = "textBox_UserPassword01";
            this.textBox_UserPassword01.PasswordChar = '*';
            this.textBox_UserPassword01.Size = new System.Drawing.Size(174, 20);
            this.textBox_UserPassword01.TabIndex = 16;
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Location = new System.Drawing.Point(395, 29);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(174, 20);
            this.textBox_UserName.TabIndex = 15;
            // 
            // textBox_UserID
            // 
            this.textBox_UserID.Location = new System.Drawing.Point(101, 29);
            this.textBox_UserID.Name = "textBox_UserID";
            this.textBox_UserID.Size = new System.Drawing.Size(174, 20);
            this.textBox_UserID.TabIndex = 14;
            this.textBox_UserID.TextChanged += new System.EventHandler(this.AddingUserForm_Load);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(306, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "用户拒绝：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "用户类型：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "再次输入密码：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "用户密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "用户名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "用户编号：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox_CertificateType);
            this.groupBox2.Controls.Add(this.textBox_UserAddress);
            this.groupBox2.Controls.Add(this.radioButton_SexGirl);
            this.groupBox2.Controls.Add(this.radioButton_SexBoy);
            this.groupBox2.Controls.Add(this.textBox_UserDescription);
            this.groupBox2.Controls.Add(this.textBox_Contact);
            this.groupBox2.Controls.Add(this.textBox_CertificateNumber);
            this.groupBox2.Controls.Add(this.dateTimePicker_BirthDate);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(594, 159);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "用户个人信息：";
            // 
            // comboBox_CertificateType
            // 
            this.comboBox_CertificateType.FormattingEnabled = true;
            this.comboBox_CertificateType.Location = new System.Drawing.Point(101, 59);
            this.comboBox_CertificateType.Name = "comboBox_CertificateType";
            this.comboBox_CertificateType.Size = new System.Drawing.Size(200, 21);
            this.comboBox_CertificateType.TabIndex = 24;
            // 
            // textBox_UserAddress
            // 
            this.textBox_UserAddress.Location = new System.Drawing.Point(403, 90);
            this.textBox_UserAddress.Name = "textBox_UserAddress";
            this.textBox_UserAddress.Size = new System.Drawing.Size(166, 20);
            this.textBox_UserAddress.TabIndex = 23;
            // 
            // radioButton_SexGirl
            // 
            this.radioButton_SexGirl.AutoSize = true;
            this.radioButton_SexGirl.Location = new System.Drawing.Point(470, 24);
            this.radioButton_SexGirl.Name = "radioButton_SexGirl";
            this.radioButton_SexGirl.Size = new System.Drawing.Size(37, 17);
            this.radioButton_SexGirl.TabIndex = 22;
            this.radioButton_SexGirl.TabStop = true;
            this.radioButton_SexGirl.Text = "女";
            this.radioButton_SexGirl.UseVisualStyleBackColor = true;
            // 
            // radioButton_SexBoy
            // 
            this.radioButton_SexBoy.AutoSize = true;
            this.radioButton_SexBoy.Checked = true;
            this.radioButton_SexBoy.Location = new System.Drawing.Point(395, 24);
            this.radioButton_SexBoy.Name = "radioButton_SexBoy";
            this.radioButton_SexBoy.Size = new System.Drawing.Size(37, 17);
            this.radioButton_SexBoy.TabIndex = 21;
            this.radioButton_SexBoy.TabStop = true;
            this.radioButton_SexBoy.Text = "男";
            this.radioButton_SexBoy.UseVisualStyleBackColor = true;
            // 
            // textBox_UserDescription
            // 
            this.textBox_UserDescription.Location = new System.Drawing.Point(109, 124);
            this.textBox_UserDescription.Name = "textBox_UserDescription";
            this.textBox_UserDescription.Size = new System.Drawing.Size(460, 20);
            this.textBox_UserDescription.TabIndex = 20;
            // 
            // textBox_Contact
            // 
            this.textBox_Contact.Location = new System.Drawing.Point(101, 90);
            this.textBox_Contact.Name = "textBox_Contact";
            this.textBox_Contact.Size = new System.Drawing.Size(200, 20);
            this.textBox_Contact.TabIndex = 19;
            // 
            // textBox_CertificateNumber
            // 
            this.textBox_CertificateNumber.Location = new System.Drawing.Point(403, 59);
            this.textBox_CertificateNumber.Name = "textBox_CertificateNumber";
            this.textBox_CertificateNumber.Size = new System.Drawing.Size(166, 20);
            this.textBox_CertificateNumber.TabIndex = 18;
            // 
            // dateTimePicker_BirthDate
            // 
            this.dateTimePicker_BirthDate.Location = new System.Drawing.Point(101, 22);
            this.dateTimePicker_BirthDate.Name = "dateTimePicker_BirthDate";
            this.dateTimePicker_BirthDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_BirthDate.TabIndex = 17;
            this.dateTimePicker_BirthDate.Value = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "用户描述：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(330, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "证件号码：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "联系方式：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(330, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "用户地址：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "证件类型：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "出生日期：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "性别：";
            // 
            // AddingUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 400);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddingUserForm";
            this.Text = "添加用户";
            this.Load += new System.EventHandler(this.AddingUserForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox_UserType;
        private System.Windows.Forms.TextBox textBox_UserPassword02;
        private System.Windows.Forms.TextBox textBox_UserPassword01;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.TextBox textBox_UserID;
        private System.Windows.Forms.RadioButton radioButton_DenyNo;
        private System.Windows.Forms.RadioButton radioButton_DenyYes;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimePicker_BirthDate;
        private System.Windows.Forms.ComboBox comboBox_CertificateType;
        private System.Windows.Forms.TextBox textBox_UserAddress;
        private System.Windows.Forms.RadioButton radioButton_SexGirl;
        private System.Windows.Forms.RadioButton radioButton_SexBoy;
        private System.Windows.Forms.TextBox textBox_UserDescription;
        private System.Windows.Forms.TextBox textBox_Contact;
        private System.Windows.Forms.TextBox textBox_CertificateNumber;
    }
}