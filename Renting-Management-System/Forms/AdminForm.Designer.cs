﻿namespace Renting_Management_System.Forms
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注销LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.退出XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客户操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.代码库操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查找ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.所有用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(554, 24);
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
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.文件FToolStripMenuItem.Text = "文件(&F)";
            // 
            // 注销LToolStripMenuItem
            // 
            this.注销LToolStripMenuItem.Name = "注销LToolStripMenuItem";
            this.注销LToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.注销LToolStripMenuItem.Text = "注销(&L)";
            this.注销LToolStripMenuItem.Click += new System.EventHandler(this.注销LToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(109, 6);
            // 
            // 退出XToolStripMenuItem
            // 
            this.退出XToolStripMenuItem.Name = "退出XToolStripMenuItem";
            this.退出XToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
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
            this.代码库操作ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.代码库操作ToolStripMenuItem.Text = "代码库(&S)";
            this.代码库操作ToolStripMenuItem.Click += new System.EventHandler(this.代码库操作ToolStripMenuItem_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 查找ToolStripMenuItem
            // 
            this.查找ToolStripMenuItem.Name = "查找ToolStripMenuItem";
            this.查找ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.查找ToolStripMenuItem.Text = "查找与修改用户";
            // 
            // 添加用户ToolStripMenuItem
            // 
            this.添加用户ToolStripMenuItem.Name = "添加用户ToolStripMenuItem";
            this.添加用户ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.添加用户ToolStripMenuItem.Text = "添加用户";
            this.添加用户ToolStripMenuItem.Click += new System.EventHandler(this.添加用户ToolStripMenuItem_Click);
            // 
            // 所有用户ToolStripMenuItem
            // 
            this.所有用户ToolStripMenuItem.Name = "所有用户ToolStripMenuItem";
            this.所有用户ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.所有用户ToolStripMenuItem.Text = "所有用户";
            this.所有用户ToolStripMenuItem.Click += new System.EventHandler(this.所有用户ToolStripMenuItem_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 266);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}