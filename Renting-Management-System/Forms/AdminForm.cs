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
        LoginForm loginForm;
        Renting_Management_System.Models.UserMod _user;
        Renting_Management_System.DAL.UserDAL userDAL;
        Renting_Management_System.DAL.UserTypeDAL userTypeDAL;
        public AdminForm()
        {
            InitializeComponent();
            loginForm = new LoginForm();
            /*_user = new Renting_Management_System.Models.UserMod();
            userDAL = new Renting_Management_System.DAL.UserDAL();
            userTypeDAL=new Renting_Management_System.DAL.UserTypeDAL();
            _user = userDAL.SelectByID(loginForm.UserIDtextBox.Text);
            if (_user == null)
            {
                toolStripStatusLabel_UserName.Text = "";
                toolStripStatusLabel_UserType.Text = "";
            }
            else
            {
                toolStripStatusLabel_UserName.Text = _user.UserName;
                toolStripStatusLabel_UserType.Text = userTypeDAL.SelectData(_user.UserTypeCode).UserTypeName;
            }*/

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
