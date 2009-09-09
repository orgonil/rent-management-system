namespace Renting_Management_System
{
    partial class LoginForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UserIDtextBox = new System.Windows.Forms.TextBox();
            this.UserPasswordtextBox = new System.Windows.Forms.TextBox();
            this.UserTypecomboBox = new System.Windows.Forms.ComboBox();
            this.Loginbutton = new System.Windows.Forms.Button();
            this.Canclebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户编号:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户密码:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "用户类型:";
            // 
            // UserIDtextBox
            // 
            this.UserIDtextBox.Location = new System.Drawing.Point(100, 24);
            this.UserIDtextBox.Name = "UserIDtextBox";
            this.UserIDtextBox.Size = new System.Drawing.Size(121, 21);
            this.UserIDtextBox.TabIndex = 3;
            // 
            // UserPasswordtextBox
            // 
            this.UserPasswordtextBox.Location = new System.Drawing.Point(100, 61);
            this.UserPasswordtextBox.Name = "UserPasswordtextBox";
            this.UserPasswordtextBox.PasswordChar = '@';
            this.UserPasswordtextBox.Size = new System.Drawing.Size(121, 21);
            this.UserPasswordtextBox.TabIndex = 4;
            // 
            // UserTypecomboBox
            // 
            this.UserTypecomboBox.FormattingEnabled = true;
            this.UserTypecomboBox.Location = new System.Drawing.Point(100, 96);
            this.UserTypecomboBox.Name = "UserTypecomboBox";
            this.UserTypecomboBox.Size = new System.Drawing.Size(121, 20);
            this.UserTypecomboBox.TabIndex = 5;
            // 
            // Loginbutton
            // 
            this.Loginbutton.Location = new System.Drawing.Point(29, 142);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(75, 21);
            this.Loginbutton.TabIndex = 6;
            this.Loginbutton.Text = "登录";
            this.Loginbutton.UseVisualStyleBackColor = true;
            this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // Canclebutton
            // 
            this.Canclebutton.Location = new System.Drawing.Point(146, 142);
            this.Canclebutton.Name = "Canclebutton";
            this.Canclebutton.Size = new System.Drawing.Size(75, 21);
            this.Canclebutton.TabIndex = 7;
            this.Canclebutton.Text = "取消";
            this.Canclebutton.UseVisualStyleBackColor = true;
            this.Canclebutton.Click += new System.EventHandler(this.Canclebutton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 186);
            this.Controls.Add(this.Canclebutton);
            this.Controls.Add(this.Loginbutton);
            this.Controls.Add(this.UserTypecomboBox);
            this.Controls.Add(this.UserPasswordtextBox);
            this.Controls.Add(this.UserIDtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Text = "登录系统";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserIDtextBox;
        private System.Windows.Forms.TextBox UserPasswordtextBox;
        private System.Windows.Forms.ComboBox UserTypecomboBox;
        private System.Windows.Forms.Button Loginbutton;
        private System.Windows.Forms.Button Canclebutton;
    }
}

