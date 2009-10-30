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
    public partial class StoreForm : Form
    {
        public StoreForm()
        {
            InitializeComponent();

            LoginForm form = new LoginForm();

            toolStripStatusLabel_UserName.Text = form.GetUserName();
            toolStripStatusLabel_UserType.Text = form.GetUserType();
            toolStripStatusLabel_Date.Text = DateTime.Now.ToShortDateString();
        }

        private void StoreForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void 注销LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Renting_Management_System.BLL.FormBLL form = new Renting_Management_System.BLL.FormBLL();
            form.Logout();
        }

        private void 退出XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel_Time.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
