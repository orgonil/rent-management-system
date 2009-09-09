using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Renting_Management_System.BLL
{
    class FormBLL
    {
        private Renting_Management_System.Forms.CounterForm counter;
        private Renting_Management_System.Forms.StoreForm store;
        private Renting_Management_System.Forms.AdminForm admin;
        private Renting_Management_System.DAL.UserTypeDAL userType;
        /// <summary>
        /// 按照用户类型代码，打开界面
        /// </summary>
        /// <param name="_userTypeCode"></param>
        public void OpenForm(string _userTypeCode)
        {
            switch (_userTypeCode)
            {
                case "A001":
                    admin = new Renting_Management_System.Forms.AdminForm();
                    admin.Show();
                    break;
                case "C002":
                    counter = new Renting_Management_System.Forms.CounterForm();
                    counter.Show();
                    break;
                default:
                    store = new Renting_Management_System.Forms.StoreForm();
                    store.Show();
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
    }
}
