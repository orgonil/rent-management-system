using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Renting_Management_System.BLL
{
    class FormBLL
    {
        private Renting_Management_System.Forms.CounterForm counterForm;
        private Renting_Management_System.Forms.StoreForm storeForm;
        private Renting_Management_System.Forms.AdminForm adminForm;
        private LoginForm loginForm;
        /// <summary>
        /// 按照用户类型代码，打开界面
        /// </summary>
        /// <param name="_userTypeCode"></param>
        public void OpenForm(string _userTypeCode)
        {
            switch (_userTypeCode)
            {
                case "A001":
                    adminForm = new Renting_Management_System.Forms.AdminForm();
                    adminForm.Show();
                    break;
                case "C002":
                    counterForm = new Renting_Management_System.Forms.CounterForm();
                    counterForm.Show();
                    break;
                default:
                    storeForm = new Renting_Management_System.Forms.StoreForm();
                    storeForm.Show();
                    break;
            }
        }
        /// <summary>
        /// 登录系统，返回 true 表示正确
        /// </summary>
        /// <param name="_user"></param>
        /// <returns></returns>
        public bool Login(Renting_Management_System.Models.UserMod _user)
        {
            Renting_Management_System.Models.UserMod user = new Renting_Management_System.Models.UserMod();
            Renting_Management_System.DAL.UserDAL userDAL = new Renting_Management_System.DAL.UserDAL();
            user = userDAL.SelectByID(_user.UserID);
            if (user != null)
            {
                if (user.UserPassword == _user.UserPassword && user.UserTypeCode == _user.UserTypeCode)
                {
                    return true;
                }
                else
                { return false; }
            }
            else
            { return false; }
        }
        /// <summary>
        /// 注销用户
        /// </summary>
        public void Logout()
        {
            loginForm = new LoginForm();
            loginForm.ShowDialog();
        }
    }
}
