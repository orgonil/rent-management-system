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
    public partial class CounterForm : Form
    {
        LoginForm loginForm;
        Renting_Management_System.Models.UserMod _user;
        Renting_Management_System.Models.UserTypeMod _userType;
        Renting_Management_System.DAL.UserDAL userDAL;
        Renting_Management_System.DAL.UserTypeDAL userTypeDAL;
        public CounterForm()
        {
            InitializeComponent();
            loginForm = new LoginForm();
            userDAL = new Renting_Management_System.DAL.UserDAL();
            userTypeDAL = new Renting_Management_System.DAL.UserTypeDAL();
            _user = new Renting_Management_System.Models.UserMod();
            _userType = new Renting_Management_System.Models.UserTypeMod();
            _user = userDAL.SelectByID(loginForm.UserIDtextBox.Text);
            _userType = userTypeDAL.SelectData(_user.UserTypeCode);
            toolStripStatusLabel_UserName.Text = _user.UserName;
            toolStripStatusLabel_UserType.Text = _userType.UserTypeName;
            toolStripStatusLabel_Date.Text = DateTime.Now.ToShortDateString();
        }

        private void CounterForm_FormClosed(object sender, FormClosedEventArgs e)
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
