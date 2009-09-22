using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Renting_Management_System.DAL
{
    class UserTypeDAL
    {
        public Renting_Management_System.Models.UserTypeMod type;
        public Renting_Management_System.DAL.DBConnection da;
        /// <summary>
        /// 获取所有数据，整个表
        /// </summary>
        /// <returns></returns>
        public DataSet GetAll()
        {
            da = new DBConnection();
            DataSet ds = new DataSet();
            ds = da.SelectQuery("Select * from [UserType]");
            ds.Tables[0].TableName = "UserType";
            return ds;
        }
        public void Update(DataSet dataSet)
        {
            da = new DBConnection();
            da.Refresh(dataSet);
        }
        /// <summary>
        /// 获取一个用户类
        /// </summary>
        /// <param name="_userTypeCode"></param>
        /// <returns></returns>
        public Renting_Management_System.Models.UserTypeMod SelectData(string _userTypeCode)
        {
            da = new DBConnection();
            DataSet ds = new DataSet();
            StringBuilder selectStr = new StringBuilder();
            selectStr.Append("Select * From [UserType] ");
            selectStr.Append("Where 用户类代码 = '");
            selectStr.Append(_userTypeCode);
            selectStr.Append("'");
            ds = da.SelectQuery(selectStr.ToString());
            if (ds.Tables.Count == 0)
            {
                return null;
            }
            else
            {
                type = new Renting_Management_System.Models.UserTypeMod();
                type.UserTypeCode = ds.Tables[0].Rows[0][0].ToString();
                type.UserTypeName = ds.Tables[0].Rows[0][1].ToString();
                return type;
            }
        }
        /// <summary>
        /// 删除一个用户类
        /// 返回 true 表示成功；
        /// 返回 false 表示该类不存在
        /// </summary>
        /// <param name="_userType"></param>
        /// <returns></returns>
        public bool DeleteData(Renting_Management_System.Models.UserTypeMod _userType)
        {
            type = new Renting_Management_System.Models.UserTypeMod();
            type = SelectData(_userType.UserTypeCode);
            if (type != null)
            {
                da = new DBConnection();
                StringBuilder deleteStr = new StringBuilder();
                deleteStr.Append("Delete From [UserType]");
                deleteStr.Append("Where 用户类代码 = '");
                deleteStr.Append(type.UserTypeCode);
                deleteStr.Append("'");
                da.DeleteQuery(deleteStr.ToString());
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// 修改一个用户类名称
        /// 返回 true 表示成功
        /// 返回 false 表示该类不存在
        /// </summary>
        /// <param name="_userType"></param>
        /// <returns></returns>
        public bool ModifyData(Renting_Management_System.Models.UserTypeMod _userType)
        {
            type = new Renting_Management_System.Models.UserTypeMod();
            type = SelectData(_userType.UserTypeCode);
            if (type != null)
            {
                da = new DBConnection();
                StringBuilder modifyStr = new StringBuilder();
                modifyStr.Append("Update [UserType]");
                modifyStr.Append("Set 用户类名称 = '");
                modifyStr.Append(type.UserTypeName + "'");
                modifyStr.Append("Where 用户类代码 = '");
                modifyStr.Append(type.UserTypeCode + "'");
                da.UpdateQuery(modifyStr.ToString());
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// 添加一个用户类
        /// 返回 true 表示成功
        /// 返回 false 表示数据已存在
        /// </summary>
        /// <param name="_userType"></param>
        /// <returns></returns>
        public bool AddData(Renting_Management_System.Models.UserTypeMod _userType)
        {
            type = new Renting_Management_System.Models.UserTypeMod();
            type = SelectData(_userType.UserTypeCode);
            if (type == null)
            {
                da = new DBConnection();
                StringBuilder insertStr = new StringBuilder();
                insertStr.Append("Insert Into [UserType] (用户类代码,用户类名称)");
                insertStr.Append("Values ('");
                insertStr.Append(type.UserTypeCode + "','");
                insertStr.Append(type.UserTypeName);
                insertStr.Append("')");
                da.InsertQuery(insertStr.ToString());
                return true;
            }
            else
                return false;
        }

    }
}
