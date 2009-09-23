using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Renting_Management_System
{
   public partial class LoginForm : Form
    {
       private Renting_Management_System.BLL.FormBLL form;
       private Renting_Management_System.Models.UserMod user;
       private Renting_Management_System.DAL.UserTypeDAL _userType;
       public string userTypeCode;
       public LoginForm()
        {
            InitializeComponent();
            _userType = new Renting_Management_System.DAL.UserTypeDAL();
            DataSet ds = new DataSet();
            ds = _userType.GetAll();
            UserTypecomboBox.DataSource = ds.Tables[0];
            UserTypecomboBox.DisplayMember = ds.Tables[0].Columns[1].ColumnName;
            UserTypecomboBox.ValueMember = ds.Tables[0].Columns[0].ColumnName;
            UserTypecomboBox.SelectedValue = "";
        }

        private void Canclebutton_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            bool yes;
            user = new Renting_Management_System.Models.UserMod();
            user.UserID = UserIDtextBox.Text;
            user.UserPassword = UserPasswordtextBox.Text;
            if (UserTypecomboBox.SelectedValue == null)
            {
                UserTypecomboBox.SelectedIndex = 0;
            }
            user.UserTypeCode = UserTypecomboBox.SelectedValue.ToString();
            userTypeCode = UserTypecomboBox.SelectedValue.ToString();
            form = new Renting_Management_System.BLL.FormBLL();
            yes = form.Login(user);
            if (yes)
            {
                if(form.Deny(user))
                {
                    MessageBox.Show("用户已被拒绝，请跟管理员联系！");
                    return;
                }
                else 
                {
                    form.OpenForm(user.UserTypeCode);
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("用户编号、用户密码有误，请重试！");
                return;
            }
        }
    }
}
