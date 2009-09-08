using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Renting_Management_System.BLL
{
    class LoginBLL
    {
        /// <summary>
        /// 登录系统，返回 true 如果正确
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
