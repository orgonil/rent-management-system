using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Renting_Management_System.DAL
{
    class CustomerDAL
    {
        public Renting_Management_System.Models.CustomerMod customer;
        public Renting_Management_System.DAL.DBConnection da;
        /// <summary>
        /// 获取所有数据，整个表的记录
        /// </summary>
        /// <returns></returns>
        public DataSet GetAll()
        {
            StringBuilder selectStr = new StringBuilder();
            selectStr.Append("Select * From [Customer]");
            DataSet ds = new DataSet();
            da = new DBConnection();
            ds = da.SelectQuery(selectStr.ToString());
            ds.Tables[0].TableName = "Customer";
            return ds;
        }
        /// <summary>
        /// 更新数据集
        /// </summary>
        /// <param name="dataSet"></param>
        public void Update(DataSet dataSet)
        {
            da = new DBConnection();
            da.Refresh(dataSet);
        }
        /// <summary>
        /// 通过客户编号获取一个客户，null 表示数据不存在
        /// </summary>
        /// <param name="_customerID"></param>
        /// <returns></returns>
        public Renting_Management_System.Models.CustomerMod SelectByID(string _customerID)
        {
            StringBuilder selectStr = new StringBuilder();
            selectStr.Append("Select * from [Customer]");
            selectStr.Append("Where 客户编号 = '");
            selectStr.Append(_customerID);
            selectStr.Append("'");
            da = new DBConnection();
            DataSet ds = new DataSet();
            ds = da.SelectQuery(selectStr.ToString());
            if (ds.Tables.Count != 0)
            {
                customer = new Renting_Management_System.Models.CustomerMod();
                customer.CustomerID = ds.Tables[0].Rows[0]["客户编号"].ToString().Trim();
                customer.CustomerTypeCode = ds.Tables[0].Rows[0]["客户类代码"].ToString().Trim();
                customer.CustomerName = ds.Tables[0].Rows[0]["客户名称"].ToString().Trim();
                customer.Sex = char.Parse(ds.Tables[0].Rows[0]["性别"].ToString().Trim());
                customer.BirthDate = DateTime.Parse(ds.Tables[0].Rows[0]["出生日期"].ToString().Trim());
                customer.CertificateTypeCode = ds.Tables[0].Rows[0]["证件类代码"].ToString().Trim();
                customer.CertificateNumber = ds.Tables[0].Rows[0]["证件号码"].ToString().Trim();
                customer.CustomerAddress = ds.Tables[0].Rows[0]["客户地址"].ToString().Trim();
                customer.CustomerContact = ds.Tables[0].Rows[0]["联系方式"].ToString().Trim();
                customer.CustomerState = ds.Tables[0].Rows[0]["客户状态"].ToString().Trim();
                customer.CustomerDescription = ds.Tables[0].Rows[0]["客户描述"].ToString().Trim();
                customer.CustomerDeny = bool.Parse(ds.Tables[0].Rows[0]["客户拒绝"].ToString().Trim());
                return customer;
            }
            else
            { return null; }
        }
        /// <summary>
        /// 通过客户名称获取一个客户，null 表示数据不存在
        /// </summary>
        /// <param name="_customerName"></param>
        /// <returns></returns>
        public Renting_Management_System.Models.CustomerMod SelectByName(string _customerName)
        {
            StringBuilder selectStr = new StringBuilder();
            selectStr.Append("Select * from [Customer]");
            selectStr.Append("Where 客户名称 = '");
            selectStr.Append(_customerName);
            selectStr.Append("'");
            da = new DBConnection();
            DataSet ds = new DataSet();
            ds = da.SelectQuery(selectStr.ToString());
            if (ds.Tables.Count != 0)
            {
                customer = new Renting_Management_System.Models.CustomerMod();
                customer.CustomerID = ds.Tables[0].Rows[0]["客户编号"].ToString().Trim();
                customer.CustomerTypeCode = ds.Tables[0].Rows[0]["客户类代码"].ToString().Trim();
                customer.CustomerName = ds.Tables[0].Rows[0]["客户名称"].ToString().Trim();
                customer.Sex = char.Parse(ds.Tables[0].Rows[0]["性别"].ToString().Trim());
                customer.BirthDate = DateTime.Parse(ds.Tables[0].Rows[0]["出生日期"].ToString().Trim());
                customer.CertificateTypeCode = ds.Tables[0].Rows[0]["证件类代码"].ToString().Trim();
                customer.CertificateNumber = ds.Tables[0].Rows[0]["证件号码"].ToString().Trim();
                customer.CustomerAddress = ds.Tables[0].Rows[0]["客户地址"].ToString().Trim();
                customer.CustomerContact = ds.Tables[0].Rows[0]["联系方式"].ToString().Trim();
                customer.CustomerState = ds.Tables[0].Rows[0]["客户状态"].ToString().Trim();
                customer.CustomerDescription = ds.Tables[0].Rows[0]["客户描述"].ToString().Trim();
                customer.CustomerDeny = bool.Parse(ds.Tables[0].Rows[0]["客户拒绝"].ToString().Trim());
                return customer;
            }
            else
            { return null; }
        }
        /// <summary>
        /// 通过客户类代码获取一个客户的数据集，null 表示没有任何记录
        /// </summary>
        /// <param name="_customerTypeCode"></param>
        /// <returns></returns>
        public DataSet SelectByTypeCode(string _customerTypeCode)
        {
            StringBuilder selectStr = new StringBuilder();
            selectStr.Append("Select * from [Customer]");
            selectStr.Append("Where 客户类代码 = '");
            selectStr.Append(_customerTypeCode);
            selectStr.Append("'");
            da = new DBConnection();
            DataSet ds = new DataSet();
            ds = da.SelectQuery(selectStr.ToString());
            if (ds.Tables.Count != 0)
            {
                return ds;
            }
            else
            { return null; }
        }
        /// <summary>
        /// 添加一个客户
        /// 返回 true 表示成功，否侧数据已存在
        /// </summary>
        /// <param name="_customer"></param>
        /// <returns></returns>
        public bool AddData(Renting_Management_System.Models.CustomerMod _customer)
        {
            customer = new Renting_Management_System.Models.CustomerMod();
            customer = SelectByID(_customer.CustomerID);
            if (customer == null)
            {
                StringBuilder insertStr = new StringBuilder();
                insertStr.Append("Insert Into [Customer]");
                insertStr.Append("(客户编号,客户类代码,客户名称,性别,出生日期,证件类代码,证件号码,客户地址,联系方式,客户状态,客户描述,客户拒绝)");
                insertStr.Append("Values ('");
                insertStr.Append(customer.CustomerID + "','");
                insertStr.Append(customer.CustomerTypeCode + "','");
                insertStr.Append(customer.CustomerName + "','");
                insertStr.Append(customer.Sex + "',");
                insertStr.Append(customer.BirthDate.ToShortDateString() + ",'");
                insertStr.Append(customer.CertificateTypeCode + "','");
                insertStr.Append(customer.CertificateNumber + "','");
                insertStr.Append(customer.CustomerAddress + "','");
                insertStr.Append(customer.CustomerContact + "','");
                insertStr.Append(customer.CustomerState + "','");
                insertStr.Append(customer.CustomerDescription + "','");
                insertStr.Append(customer.CustomerDeny.ToString());
                insertStr.Append("')");
                da = new DBConnection();
                da.InsertQuery(insertStr.ToString());
                return true;
            }
            else
            { return false; }
        }
        /// <summary>
        /// 修改一个客户的记录
        /// 返回 true 表示成功，否侧表示数据不存在
        /// </summary>
        /// <param name="_customer"></param>
        /// <returns></returns>
        public bool ModifyData(Renting_Management_System.Models.CustomerMod _customer)
        {
            customer = new Renting_Management_System.Models.CustomerMod();
            customer = SelectByID(_customer.CustomerID);
            if (customer != null)
            {
                StringBuilder updateStr = new StringBuilder();
                updateStr.Append("Update [Customer] ");
                updateStr.Append("Set ");
                updateStr.Append("客户类代码 = '");
                updateStr.Append(customer.CustomerTypeCode + "'");
                updateStr.Append(",客户名称 = '");
                updateStr.Append(customer.CustomerName + "'");
                updateStr.Append(",性别 = '");
                updateStr.Append(customer.Sex + "'");
                updateStr.Append(",出生日期 = ");
                updateStr.Append(customer.BirthDate.ToShortDateString());
                updateStr.Append(",证件类代码 = '");
                updateStr.Append(customer.CertificateTypeCode + "'");
                updateStr.Append(",证件号码 = '");
                updateStr.Append(customer.CertificateNumber + "'");
                updateStr.Append(",客户地址 = '");
                updateStr.Append(customer.CustomerAddress + "'");
                updateStr.Append(",联系方式 = '");
                updateStr.Append(customer.CustomerContact + "'");
                updateStr.Append(",客户状态 = '");
                updateStr.Append(customer.CustomerState + "'");
                updateStr.Append(",客户描述 = '");
                updateStr.Append(customer.CustomerDescription + "'");
                updateStr.Append(",客户拒绝 = '");
                updateStr.Append(customer.CustomerDeny.ToString() + "'");
                updateStr.Append("Where 客户编号 = '");
                updateStr.Append(customer.CustomerID + "'");
                da = new DBConnection();
                da.UpdateQuery(updateStr.ToString());
                return true;
            }
            else
            { return false; }
        }
        /// <summary>
        /// 删除一个客户
        /// 返回 true 表示成功，否侧数据不存在
        /// </summary>
        /// <param name="_customer"></param>
        /// <returns></returns>
        public bool DeleteData(Renting_Management_System.Models.CustomerMod _customer)
        {
            customer = new Renting_Management_System.Models.CustomerMod();
            customer = SelectByID(_customer.CustomerID);
            if (customer != null)
            {
                StringBuilder deleteStr = new StringBuilder();
                deleteStr.Append("Delete From [Customer]");
                deleteStr.Append("Where 客户编号 = '");
                deleteStr.Append(customer.CustomerID);
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
