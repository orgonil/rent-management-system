using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Renting_Management_System.DAL
{
    class ClientTypeDAL
    {
        public Renting_Management_System.Models.ClientTypeMod type;
        public Renting_Management_System.DAL.DBConnection da;
        /// <summary>
        /// 获取所有数据，整个表
        /// </summary>
        /// <returns></returns>
        public DataSet GetAll()
        {
            da = new DBConnection();
            DataSet ds = new DataSet();
            ds = da.SelectQuery("Select * from Kehulei");
            return ds;
        }
        /// <summary>
        /// 获取一个客户类
        /// </summary>
        /// <param name="_userTypeCode"></param>
        /// <returns></returns>
        public Renting_Management_System.Models.ClientTypeMod SelectData(string _clientTypeCode)
        {
            type = new Renting_Management_System.Models.ClientTypeMod();
            type.ClientTypeCode = _clientTypeCode;
            da = new DBConnection();
            DataSet ds = new DataSet();
            StringBuilder selectStr = new StringBuilder();
            selectStr.Append("Select * From Kehulei");
            selectStr.Append("Where 客户类代码 = '");
            selectStr.Append(type.ClientTypeCode);
            selectStr.Append("'");
            ds = da.SelectQuery(selectStr.ToString());
            if (ds.Tables.Count == 0)
            {
                return null;
            }
            else
            {
                type.ClientTypeCode = ds.Tables[0].Rows[0]["客户类代码"].ToString().Trim();
                type.ClientTypeName = ds.Tables[0].Rows[0]["客户类名称"].ToString().Trim();
                return type;
            }
        }
        /// <summary>
        /// 删除一个客户类
        /// 返回 true 表示成功；
        /// 返回 false 表示该类不存在
        /// </summary>
        /// <param name="uType"></param>
        /// <returns></returns>
        public bool DeleteData(Renting_Management_System.Models.ClientTypeMod cType)
        {
            type = new Renting_Management_System.Models.ClientTypeMod();
            type = SelectData(cType.ClientTypeCode);
            if (type != null)
            {
                da = new DBConnection();
                StringBuilder deleteStr = new StringBuilder();
                deleteStr.Append("Delete From Kehulei");
                deleteStr.Append("Where 客户类代码 = '");
                deleteStr.Append(type.ClientTypeCode);
                deleteStr.Append("'");
                da.DeleteQuery(deleteStr.ToString());
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// 修改一个客户类名称
        /// 返回 true 表示成功
        /// 返回 false 表示该类不存在
        /// </summary>
        /// <param name="uType"></param>
        /// <returns></returns>
        public bool ModifyData(Renting_Management_System.Models.ClientTypeMod cType)
        {
            type = new Renting_Management_System.Models.ClientTypeMod();
            type = SelectData(cType.ClientTypeCode);
            if (type != null)
            {
                da = new DBConnection();
                StringBuilder modifyStr = new StringBuilder();
                modifyStr.Append("Update Kehulei");
                modifyStr.Append("Set 客户类名称 = '");
                modifyStr.Append(type.ClientTypeName + "'");
                modifyStr.Append("Where 客户类代码 = '");
                modifyStr.Append(type.ClientTypeCode + "'");
                da.UpdateQuery(modifyStr.ToString());
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// 添加一个客户类
        /// 返回 true 表示成功
        /// 返回 false 表示数据已存在
        /// </summary>
        /// <param name="uType"></param>
        /// <returns></returns>
        public bool AddData(Renting_Management_System.Models.ClientTypeMod cType)
        {
            type = new Renting_Management_System.Models.ClientTypeMod();
            type = SelectData(cType.ClientTypeCode);
            if (type == null)
            {
                da = new DBConnection();
                StringBuilder insertStr = new StringBuilder();
                insertStr.Append("Insert Into Kehulei (客户类代码,客户类名称)");
                insertStr.Append("Values ('");
                insertStr.Append(type.ClientTypeCode + "','");
                insertStr.Append(type.ClientTypeName);
                insertStr.Append("')");
                da.InsertQuery(insertStr.ToString());
                return true;
            }
            else
                return false;
        }
    }
}
