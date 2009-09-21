namespace Renting_Management_System.Forms
{
    partial class AdminForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注销LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.退出XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查找ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.所有用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客户操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.代码库操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabe1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_UserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_UserType = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_Date = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_Time = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.用户操作ToolStripMenuItem,
            this.客户操作ToolStripMenuItem,
            this.代码库操作ToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(793, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.注销LToolStripMenuItem,
            this.toolStripMenuItem1,
            this.退出XToolStripMenuItem});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.文件FToolStripMenuItem.Text = "文件(&F)";
            // 
            // 注销LToolStripMenuItem
            // 
            this.注销LToolStripMenuItem.Name = "注销LToolStripMenuItem";
            this.注销LToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.注销LToolStripMenuItem.Text = "注销(&L)";
            this.注销LToolStripMenuItem.Click += new System.EventHandler(this.注销LToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(110, 6);
            // 
            // 退出XToolStripMenuItem
            // 
            this.退出XToolStripMenuItem.Name = "退出XToolStripMenuItem";
            this.退出XToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.退出XToolStripMenuItem.Text = "退出(&X)";
            this.退出XToolStripMenuItem.Click += new System.EventHandler(this.退出XToolStripMenuItem_Click);
            // 
            // 用户操作ToolStripMenuItem
            // 
            this.用户操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查找ToolStripMenuItem,
            this.添加用户ToolStripMenuItem,
            this.所有用户ToolStripMenuItem});
            this.用户操作ToolStripMenuItem.Name = "用户操作ToolStripMenuItem";
            this.用户操作ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.用户操作ToolStripMenuItem.Text = "用户(&U)";
            this.用户操作ToolStripMenuItem.Click += new System.EventHandler(this.用户操作ToolStripMenuItem_Click);
            // 
            // 查找ToolStripMenuItem
            // 
            this.查找ToolStripMenuItem.Name = "查找ToolStripMenuItem";
            this.查找ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.查找ToolStripMenuItem.Text = "查找与修改用户";
            // 
            // 添加用户ToolStripMenuItem
            // 
            this.添加用户ToolStripMenuItem.Name = "添加用户ToolStripMenuItem";
            this.添加用户ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.添加用户ToolStripMenuItem.Text = "添加用户";
            this.添加用户ToolStripMenuItem.Click += new System.EventHandler(this.添加用户ToolStripMenuItem_Click);
            // 
            // 所有用户ToolStripMenuItem
            // 
            this.所有用户ToolStripMenuItem.Name = "所有用户ToolStripMenuItem";
            this.所有用户ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.所有用户ToolStripMenuItem.Text = "所有用户";
            this.所有用户ToolStripMenuItem.Click += new System.EventHandler(this.所有用户ToolStripMenuItem_Click);
            // 
            // 客户操作ToolStripMenuItem
            // 
            this.客户操作ToolStripMenuItem.Name = "客户操作ToolStripMenuItem";
            this.客户操作ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.客户操作ToolStripMenuItem.Text = "客户(&C)";
            this.客户操作ToolStripMenuItem.Click += new System.EventHandler(this.客户操作ToolStripMenuItem_Click);
            // 
            // 代码库操作ToolStripMenuItem
            // 
            this.代码库操作ToolStripMenuItem.Name = "代码库操作ToolStripMenuItem";
            this.代码库操作ToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.代码库操作ToolStripMenuItem.Text = "代码库(&S)";
            this.代码库操作ToolStripMenuItem.Click += new System.EventHandler(this.代码库操作ToolStripMenuItem_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabe1,
            this.toolStripStatusLabel_UserName,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel_UserType,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel_Date,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel_Time});
            this.statusStrip1.Location = new System.Drawing.Point(0, 266);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(793, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabe1
            // 
            this.toolStripStatusLabe1.Name = "toolStripStatusLabe1";
            this.toolStripStatusLabe1.Size = new System.Drawing.Size(55, 17);
            this.toolStripStatusLabe1.Text = "用户名：";
            // 
            // toolStripStatusLabel_UserName
            // 
            this.toolStripStatusLabel_UserName.AutoSize = false;
            this.toolStripStatusLabel_UserName.Name = "toolStripStatusLabel_UserName";
            this.toolStripStatusLabel_UserName.Size = new System.Drawing.Size(100, 17);
            this.toolStripStatusLabel_UserName.Text = "没有人登陆!";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(67, 17);
            this.toolStripStatusLabel1.Text = "用户类型：";
            // 
            // toolStripStatusLabel_UserType
            // 
            this.toolStripStatusLabel_UserType.AutoSize = false;
            this.toolStripStatusLabel_UserType.Name = "toolStripStatusLabel_UserType";
            this.toolStripStatusLabel_UserType.Size = new System.Drawing.Size(100, 17);
            this.toolStripStatusLabel_UserType.Text = "管理员";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.AutoSize = false;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabel3.Text = "|";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(43, 17);
            this.toolStripStatusLabel4.Text = "日期：";
            // 
            // toolStripStatusLabel_Date
            // 
            this.toolStripStatusLabel_Date.AutoSize = false;
            this.toolStripStatusLabel_Date.Name = "toolStripStatusLabel_Date";
            this.toolStripStatusLabel_Date.Size = new System.Drawing.Size(150, 17);
            this.toolStripStatusLabel_Date.Text = "toolStripStatusLabel_Date";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(43, 17);
            this.toolStripStatusLabel5.Text = "时间：";
            // 
            // toolStripStatusLabel_Time
            // 
            this.toolStripStatusLabel_Time.AutoSize = false;
            this.toolStripStatusLabel_Time.Name = "toolStripStatusLabel_Time";
            this.toolStripStatusLabel_Time.Size = new System.Drawing.Size(150, 17);
            this.toolStripStatusLabel_Time.Text = "toolStripStatusLabel_Time";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 288);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注销LToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 退出XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 客户操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 代码库操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查找ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 所有用户ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabe1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_UserName;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_UserType;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Date;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Time;
        private System.Windows.Forms.Timer timer1;
    }
}