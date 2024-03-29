﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Renting_Management_System.DAL
{
    class CustomerTypeDAL
    {
        public Renting_Management_System.Models.CustomerTypeMod type;
        public Renting_Management_System.DAL.DBConnection da;
        /// <summary>
        /// 获取所有数据，整个表
        /// </summary>
        /// <returns></returns>
        public DataSet GetAll()
        {
            da = new DBConnection();
            DataSet ds = new DataSet();
            ds = da.SelectQuery("Select * from [CustomerType]");
            ds.Tables[0].TableName = "CustomerType";
            return ds;
        }
        /// <summary>
        /// 获取一个客户类
        /// </summary>
        /// <param name="_userTypeCode"></param>
        /// <returns></returns>
        public Renting_Management_System.Models.CustomerTypeMod SelectData(string _customerTypeCode)
        {
            da = new DBConnection();
            DataSet ds = new DataSet();
            StringBuilder selectStr = new StringBuilder();
            selectStr.Append("Select * From [CustomerType] ");
            selectStr.Append("Where 客户类代码 = '");
            selectStr.Append(_customerTypeCode);
            selectStr.Append("'");
            ds = da.SelectQuery(selectStr.ToString());
            if (ds.Tables[0].Rows.Count == 0)
            {
                return null;
            }
            else
            {
                type = new Renting_Management_System.Models.CustomerTypeMod();
                type.CustomerTypeCode = ds.Tables[0].Rows[0][0].ToString().Trim();
                type.CustomerTypeName = ds.Tables[0].Rows[0][1].ToString().Trim();
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
        public bool DeleteData(Renting_Management_System.Models.CustomerTypeMod _customerType)
        {
            type = new Renting_Management_System.Models.CustomerTypeMod();
            type = SelectData(_customerType.CustomerTypeCode);
            if (type != null)
            {
                da = new DBConnection();
                StringBuilder deleteStr = new StringBuilder();
                deleteStr.Append("Delete From [CustomerType] ");
                deleteStr.Append("Where 客户类代码 = '");
                deleteStr.Append(_customerType.CustomerTypeCode);
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
        public bool ModifyData(Renting_Management_System.Models.CustomerTypeMod _customerType)
        {
            type = new Renting_Management_System.Models.CustomerTypeMod();
            type = SelectData(_customerType.CustomerTypeCode);
            if (type != null)
            {
                da = new DBConnection();
                StringBuilder modifyStr = new StringBuilder();
                modifyStr.Append("Update [CustomerType]");
                modifyStr.Append("Set 客户类名称 = '");
                modifyStr.Append(_customerType.CustomerTypeName + "'");
                modifyStr.Append("Where 客户类代码 = '");
                modifyStr.Append(_customerType.CustomerTypeCode + "'");
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
        public bool AddData(Renting_Management_System.Models.CustomerTypeMod _customerType)
        {
            type = new Renting_Management_System.Models.CustomerTypeMod();
            type = SelectData(_customerType.CustomerTypeCode);
            if (type == null)
            {
                da = new DBConnection();
                StringBuilder insertStr = new StringBuilder();
                insertStr.Append("Insert Into [CustomerType] (客户类代码,客户类名称)");
                insertStr.Append("Values ('");
                insertStr.Append(_customerType.CustomerTypeCode + "','");
                insertStr.Append(_customerType.CustomerTypeName);
                insertStr.Append("')");
                da.InsertQuery(insertStr.ToString());
                return true;
            }
            else
                return false;
        }
    }
}
