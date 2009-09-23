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
        public DataSet ds = new DataSet();
        private LoginForm loginForm;
        private Renting_Management_System.BLL.TableUpdate tableUpdate;
        private Renting_Management_System.Models.UserMod _user;
        private Renting_Management_System.Models.UserTypeMod _userType;
        private Renting_Management_System.DAL.UserDAL userDAL;
        private Renting_Management_System.DAL.UserTypeDAL userTypeDAL;
        public AdminForm()
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
            toolStripStatusLabel_Date.Text = DateTime.Now.ToLongDateString();
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void 退出XToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            AddingUserForm form = new AddingUserForm();
            form.ShowDialog();
        }

        private void 所有用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userDAL = new Renting_Management_System.DAL.UserDAL();
            ds.Clear();
            ds = userDAL.GetAll();
            BindingSource bds = new BindingSource();
            bds.DataSource = ds;
            bds.DataMember = ds.Tables[0].TableName;
            dataGridView1.DataSource = bds;
            bindingNavigator1.BindingSource = bds;
        }

        private void 代码库操作ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CodeLibrary codeForm = new CodeLibrary();
            codeForm.ShowDialog();
        }

        private void 客户操作ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel_Time.Text = DateTime.Now.ToLongTimeString();
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (ds.HasChanges())
            {
                tableUpdate = new Renting_Management_System.BLL.TableUpdate();
                tableUpdate.Update(ds);
            }
        }

        private void 查找ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckingUserForm form = new CheckingUserForm();
            form.ShowDialog();
        }
    }
}
