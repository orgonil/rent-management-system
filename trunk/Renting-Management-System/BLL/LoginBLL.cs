using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Renting_Management_System.BLL
{
    class LoginBLL
    {
        /// <summary>
        /// 用户登录系统
        /// 返回 false 表示用户编号、密码、和类型错误。
        /// 返回 true 表示用户编号、密码、和类型正确。
        /// </summary>
        /// <param name="_user"></param>
        /// <returns></returns>
        public bool Login(Renting_Management_System.Models.UserMod _user)
        {
            Renting_Management_System.Models.UserMod user = new Renting_Management_System.Models.UserMod();
            Renting_Management_System.DAL.UserDAL userDAL = new Renting_Management_System.DAL.UserDAL();
            user = userDAL.SelectByID(_user.UserID);
            if (user == null)
            {
                return false;
            }
            else if (_user.UserID == user.UserID && _user.UserPassword == user.UserPassword && _user.UserTypeCode == user.UserTypeCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
