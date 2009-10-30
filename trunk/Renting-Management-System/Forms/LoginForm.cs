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
       private Renting_Management_System.DAL.UserDAL userDAL;
       private Renting_Management_System.DAL.UserTypeDAL _userType;
       static private string userID;
       static private string userTypeName;

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
       
       /// <summary>
       /// 取消按钮
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void Canclebutton_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }
      
       /// <summary>
       /// 登录按钮
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
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

            userID = UserIDtextBox.Text.Trim();
            userTypeName = UserTypecomboBox.Text;

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

       /// <summary>
       /// 登录之后，获取一个用户名称
       /// </summary>
       /// <returns></returns>
       public string GetUserName()
        {
            userDAL = new Renting_Management_System.DAL.UserDAL();
            user = new Renting_Management_System.Models.UserMod();

            user = userDAL.SelectByID(userID);
            return user.UserName;
        }

       /// <summary>
       /// 登录后获取用户类型
       /// </summary>
       /// <returns></returns>
       public string GetUserType()
       {
           return userTypeName;
       }
    }
}
