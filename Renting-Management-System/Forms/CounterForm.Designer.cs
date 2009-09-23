namespace Renting_Management_System.Forms
{
    partial class CounterForm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabe1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_UserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_UserType = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_Date = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStripStatusLabel_Time = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(680, 24);
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
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabe1,
            this.toolStripStatusLabel_UserName,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel_UserType,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel_Date,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel_Time});
            this.statusStrip1.Location = new System.Drawing.Point(0, 266);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(680, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
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
            this.toolStripStatusLabel5.Click += new System.EventHandler(this.toolStripStatusLabel5_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStripStatusLabel_Time
            // 
            this.toolStripStatusLabel_Time.AutoSize = false;
            this.toolStripStatusLabel_Time.Name = "toolStripStatusLabel_Time";
            this.toolStripStatusLabel_Time.Size = new System.Drawing.Size(150, 17);
            this.toolStripStatusLabel_Time.Text = "toolStripStatusLabel_Time";
            // 
            // CounterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 288);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CounterForm";
            this.Text = "CounterForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CounterForm_FormClosed);
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabe1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_UserName;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_UserType;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Date;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Time;
    }
}