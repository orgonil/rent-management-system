using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Renting_Management_System.DAL
{
    class UserDAL
    {
        public Renting_Management_System.Models.UserMod user;
        public Renting_Management_System.DAL.DBConnection da;
        /// <summary>
        /// 获取所有数据、整个表的记录
        /// </summary>
        /// <returns></returns>
        public DataSet GetAll()
        {
            StringBuilder selectStr = new StringBuilder();
            selectStr.Append("Select * From [User] ");
            DataSet ds = new DataSet();
            da = new DBConnection();
            ds = da.SelectQuery(selectStr.ToString());
            ds.Tables[0].TableName = "User";
            return ds;
        }
        /// <summary>
        /// 通过用户编号可以获取一个用户
        /// 返回null 表示没有改用户
        /// </summary>
        /// <param name="_userID"></param>
        /// <returns></returns>
        public Renting_Management_System.Models.UserMod SelectByID(string _userID)
        {
            StringBuilder selectStr = new StringBuilder();
            selectStr.Append("Select * From [User] ");
            selectStr.Append("Where 用户编号 = '");
            selectStr.Append(_userID);
            selectStr.Append("'");
            da = new DBConnection();
            DataSet ds = new DataSet();
            ds = da.SelectQuery(selectStr.ToString());
            if (ds.Tables[0].Rows.Count == 0)
            { return null; }
            else
            {
                user = new Renting_Management_System.Models.UserMod();
                user.UserID = ds.Tables[0].Rows[0]["用户编号"].ToString().Trim();
                user.UserName = ds.Tables[0].Rows[0]["用户名称"].ToString().Trim();
                user.Sex = char.Parse(ds.Tables[0].Rows[0]["性别"].ToString().Trim());
                if (ds.Tables[0].Rows[0]["出生日期"].ToString().Trim() != "")
                {
                    user.BirthDate = DateTime.Parse(ds.Tables[0].Rows[0]["出生日期"].ToString().Trim());
                }
                user.UserPassword = ds.Tables[0].Rows[0]["用户密码"].ToString().Trim();
                user.UserTypeCode = ds.Tables[0].Rows[0]["用户类代码"].ToString().Trim();
                user.CertificateTypeCode = ds.Tables[0].Rows[0]["证件类代码"].ToString().Trim();
                user.CertificateNumber = ds.Tables[0].Rows[0]["证件号码"].ToString().Trim();
                user.UserContact = ds.Tables[0].Rows[0]["联系方式"].ToString().Trim();
                user.UserAddress = ds.Tables[0].Rows[0]["用户地址"].ToString().Trim();
                user.UserDescription = ds.Tables[0].Rows[0]["用户描述"].ToString().Trim();
                if (ds.Tables[0].Rows[0]["用户拒绝"].ToString().Trim() != "")
                {
                    user.UserDeny = bool.Parse(ds.Tables[0].Rows[0]["用户拒绝"].ToString().Trim());
                }
                return user;
            }
        }
        /// <summary>
        /// 通过用户名称可以获取一个用户
        /// 返回null 表示没有改用户
        /// </summary>
        /// <param name="_userName"></param>
        /// <returns></returns>
        public Renting_Management_System.Models.UserMod SelectByName(string _userName)
        {
            StringBuilder selectStr = new StringBuilder();
            selectStr.Append("Select * From [User]");
            selectStr.Append("Where 用户名称 = '");
            selectStr.Append(_userName);
            selectStr.Append("'");
            da = new DBConnection();
            DataSet ds = new DataSet();
            ds = da.SelectQuery(selectStr.ToString());
            if (ds.Tables[0].Rows.Count == 0)
            { return null; }
            else
            {
                user = new Renting_Management_System.Models.UserMod();
                user.UserID = ds.Tables[0].Rows[0]["用户编号"].ToString().Trim();
                user.UserName = ds.Tables[0].Rows[0]["用户名称"].ToString().Trim();
                user.Sex = char.Parse(ds.Tables[0].Rows[0]["性别"].ToString().Trim());
                if (ds.Tables[0].Rows[0]["出生日期"].ToString().Trim() != "")
                {
                    user.BirthDate = DateTime.Parse(ds.Tables[0].Rows[0]["出生日期"].ToString().Trim());
                }
                user.UserPassword = ds.Tables[0].Rows[0]["用户密码"].ToString().Trim();
                user.UserTypeCode = ds.Tables[0].Rows[0]["用户类代码"].ToString().Trim();
                user.CertificateTypeCode = ds.Tables[0].Rows[0]["证件类代码"].ToString().Trim();
                user.CertificateNumber = ds.Tables[0].Rows[0]["证件号码"].ToString().Trim();
                user.UserContact = ds.Tables[0].Rows[0]["联系方式"].ToString().Trim();
                user.UserAddress = ds.Tables[0].Rows[0]["用户地址"].ToString().Trim();
                user.UserDescription = ds.Tables[0].Rows[0]["用户描述"].ToString().Trim();
                if (ds.Tables[0].Rows[0]["用户拒绝"].ToString().Trim() != "")
                {
                    user.UserDeny = bool.Parse(ds.Tables[0].Rows[0]["用户拒绝"].ToString().Trim());
                }
                return user;
            }
        }
        /// <summary>
        /// 通过用户类代码可以获取一个用户数据集
        /// 返回 null 表示没有数据
        /// </summary>
        /// <param name="_userTypeCode"></param>
        /// <returns></returns>
        public DataSet SelectByTypeCode(string _userTypeCode)
        {
            StringBuilder selectStr = new StringBuilder();
            selectStr.Append("Select * From [User] ");
            selectStr.Append("Where 用户类代码 = '");
            selectStr.Append(_userTypeCode);
            selectStr.Append("'");
            da = new DBConnection();
            DataSet ds = new DataSet();
            ds = da.SelectQuery(selectStr.ToString());
            if (ds.Tables[0].Rows.Count == 0)
            { return null; }
            else 
            {return ds;}
        }
        /// <summary>
        /// 添加一个用户
        /// 返回 true 表示成功
        /// 返回 false 表示该数据已存在
        /// </summary>
        /// <param name="_user"></param>
        /// <returns></returns>
        public bool AddData(Renting_Management_System.Models.UserMod _user)
        {
            user = new Renting_Management_System.Models.UserMod();
            user = SelectByID(_user.UserID);
            if (user == null)
            {
                StringBuilder insertStr = new StringBuilder();
                insertStr.Append("Insert Into [User] ");
                insertStr.Append("(用户编号,用户名称,性别,出生日期,用户密码,用户类代码,证件类代码,证件号码,联系方式,用户地址,用户描述,用户拒绝)");
                insertStr.Append("Values ('");
                insertStr.Append(_user.UserID + "','");
                insertStr.Append(_user.UserName + "','");
                insertStr.Append(_user.Sex + "',");
                insertStr.Append(_user.BirthDate.ToShortDateString() + ",'");
                insertStr.Append(_user.UserPassword + "','");
                insertStr.Append(_user.UserTypeCode + "','");
                insertStr.Append(_user.CertificateTypeCode + "','");
                insertStr.Append(_user.CertificateNumber + "','");
                insertStr.Append(_user.UserContact + "','");
                insertStr.Append(_user.UserAddress + "','");
                insertStr.Append(_user.UserDescription + "','");
                insertStr.Append(_user.UserDeny.ToString());
                insertStr.Append("')");
                da = new DBConnection();
                da.InsertQuery(insertStr.ToString());
                return true;
            }
            else
            { return false; }
        }
        /// <summary>
        /// 修改一个用户
        /// 返回 true 表示成功，否则表示该用户信息不存在
        /// </summary>
        /// <param name="_user"></param>
        /// <returns></returns>
        public bool ModifyData(Renting_Management_System.Models.UserMod _user)
        {
            user = new Renting_Management_System.Models.UserMod();
            user = SelectByID(_user.UserID);
            if (user == null)
            { return false; }
            else
            {
                StringBuilder updateStr = new StringBuilder();
                updateStr.Append("Update [User]");
                updateStr.Append("Set");
                updateStr.Append("用户名称 = '");
                updateStr.Append(_user.UserName + "'");
                updateStr.Append(",性别 = '");
                updateStr.Append(_user.Sex + "'");
                updateStr.Append(",出生日期 = ");
                updateStr.Append(_user.BirthDate.ToShortDateString());
                updateStr.Append(",用户 密码 = '");
                updateStr.Append(_user.UserPassword + "'");
                updateStr.Append(",用户类代码 = '");
                updateStr.Append(_user.UserTypeCode + "'");
                updateStr.Append(",证件类代码 = '");
                updateStr.Append(_user.CertificateTypeCode + "'");
                updateStr.Append(",证件号码 = '");
                updateStr.Append(_user.CertificateNumber + "'");
                updateStr.Append(",联系方式 = '");
                updateStr.Append(_user.UserContact + "'");
                updateStr.Append(",用户地址 = '");
                updateStr.Append(_user.UserAddress + "'");
                updateStr.Append(",用户描述 = '");
                updateStr.Append(_user.UserDescription + "'");
                updateStr.Append(",用户拒绝 = '");
                updateStr.Append(_user.UserDeny.ToString());
                updateStr.Append("'");
                updateStr.Append("Where 用户编号 = '");
                updateStr.Append(_user.UserID + "'");
                da = new DBConnection();
                da.UpdateQuery(updateStr.ToString());
                return true;
            }
        }
        /// <summary>
        /// 删除一个用户
        /// 返回 true 表示删除成功
        /// 返回 false 表示数据不存在
        /// </summary>
        /// <param name="_user"></param>
        /// <returns></returns>
        public bool DeleteData(Renting_Management_System.Models.UserMod _user)
        {
            user = new Renting_Management_System.Models.UserMod();
            user = SelectByID(_user.UserID);
            if (user != null)
            {
                StringBuilder deleteStr = new StringBuilder();
                deleteStr.Append("Delete From [User]");
                deleteStr.Append("Where 用户编号 = '");
                deleteStr.Append(_user.UserID);
                deleteStr.Append("'");
                da = new DBConnection();
                da.DeleteQuery(deleteStr.ToString());
                return true;
            }
            else
            { return false; }
        }
    }
}
