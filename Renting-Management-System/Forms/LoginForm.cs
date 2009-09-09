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
       public LoginForm()
        {
            InitializeComponent();
            Renting_Management_System.DAL.UserTypeDAL _userType = new Renting_Management_System.DAL.UserTypeDAL();
            DataSet ds = new DataSet();
            ds = _userType.GetAll();
            UserTypecomboBox.DataSource = ds.Tables[0];
            UserTypecomboBox.DisplayMember = "用户类名称";
            UserTypecomboBox.ValueMember = "用户类代码";
            UserTypecomboBox.SelectedValue = "";
        }

        private void Canclebutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            bool yes;
            Renting_Management_System.Models.UserMod user = new Renting_Management_System.Models.UserMod();
            user.UserID = UserIDtextBox.Text;
            user.UserPassword = UserPasswordtextBox.Text;
            user.UserTypeCode = UserTypecomboBox.SelectedValue.ToString();
            form = new Renting_Management_System.BLL.FormBLL();
            yes = form.Login(user);
            if (yes)
            {
                form.OpenForm(user.UserTypeCode);
                this.Hide();
            }
            else
            {
                MessageBox.Show("用户编号、用户密码有误，请重试！");
                return;
            }
        }
    }
}
