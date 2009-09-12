using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Renting_Management_System.Forms
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void 退出XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Windows.Forms.Application.Exit();
        }

        private void 注销LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Renting_Management_System.BLL.FormBLL form = new Renting_Management_System.BLL.FormBLL();
            form.Logout();
        }

        private void 用户操作ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 添加用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 所有用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 代码库操作ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 客户操作ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
