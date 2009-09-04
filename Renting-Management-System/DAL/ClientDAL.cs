using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Renting_Management_System.DAL
{
    class ClientDAL
    {
        public Renting_Management_System.Models.ClientMod client;
        public Renting_Management_System.DAL.DBConnection da;
        /// <summary>
        /// 获取所有数据，整个表的记录
        /// </summary>
        /// <returns></returns>
        public DataSet GetAll()
        {
            StringBuilder selectStr = new StringBuilder();
            selectStr.Append("Select * From Kehu");
            DataSet ds = new DataSet();
            da = new DBConnection();
            ds = da.SelectQuery(selectStr.ToString());
            return ds;
        }
        /// <summary>
        /// 通过客户编号获取一个客户，null 表示数据不存在
        /// </summary>
        /// <param name="_clientID"></param>
        /// <returns></returns>
        public Renting_Management_System.Models.ClientMod SelectData_1(string _clientID)
        {
            StringBuilder selectStr = new StringBuilder();
            selectStr.Append("Select * from Kehu");
            selectStr.Append("Where 客户编号 = '");
            selectStr.Append(_clientID);
            selectStr.Append("'");
            da = new DBConnection();
            DataSet ds = new DataSet();
            ds = da.SelectQuery(selectStr.ToString());
            if (ds.Tables.Count != 0)
            {
                client = new Renting_Management_System.Models.ClientMod();
                client.ClientID = ds.Tables[0].Rows[0]["客户编号"].ToString().Trim();
                client.ClientTypeCode = ds.Tables[0].Rows[0]["客户类代码"].ToString().Trim();
                client.ClientName = ds.Tables[0].Rows[0]["客户名称"].ToString().Trim();
                client.Sex = ds.Tables[0].Rows[0]["性别"].ToString().Trim();
                client.BirthDate = DateTime.Parse(ds.Tables[0].Rows[0]["出生日期"].ToString().Trim());
                client.CertificateTypeCode = ds.Tables[0].Rows[0]["证件类代码"].ToString().Trim();
                client.CertificateNumber = ds.Tables[0].Rows[0]["证件号码"].ToString().Trim();
                client.ClientAddress = ds.Tables[0].Rows[0]["客户地址"].ToString().Trim();
                client.ClientContact = ds.Tables[0].Rows[0]["联系方式"].ToString().Trim();
                client.ClientState = ds.Tables[0].Rows[0]["客户状态"].ToString().Trim();
                client.ClientDescription = ds.Tables[0].Rows[0]["客户描述"].ToString().Trim();
                return client;
            }
            else
            { return null; }
        }
        /// <summary>
        /// 通过客户名称获取一个客户，null 表示数据不存在
        /// </summary>
        /// <param name="_clientName"></param>
        /// <returns></returns>
        public Renting_Management_System.Models.ClientMod SelectData_2(string _clientName)
        {
            StringBuilder selectStr = new StringBuilder();
            selectStr.Append("Select * from Kehu");
            selectStr.Append("Where 客户名称 = '");
            selectStr.Append(_clientName);
            selectStr.Append("'");
            da = new DBConnection();
            DataSet ds = new DataSet();
            ds = da.SelectQuery(selectStr.ToString());
            if (ds.Tables.Count != 0)
            {
                client = new Renting_Management_System.Models.ClientMod();
                client.ClientID = ds.Tables[0].Rows[0]["客户编号"].ToString().Trim();
                client.ClientTypeCode = ds.Tables[0].Rows[0]["客户类代码"].ToString().Trim();
                client.ClientName = ds.Tables[0].Rows[0]["客户名称"].ToString().Trim();
                client.Sex = ds.Tables[0].Rows[0]["性别"].ToString().Trim();
                client.BirthDate = DateTime.Parse(ds.Tables[0].Rows[0]["出生日期"].ToString().Trim());
                client.CertificateTypeCode = ds.Tables[0].Rows[0]["证件类代码"].ToString().Trim();
                client.CertificateNumber = ds.Tables[0].Rows[0]["证件号码"].ToString().Trim();
                client.ClientAddress = ds.Tables[0].Rows[0]["客户地址"].ToString().Trim();
                client.ClientContact = ds.Tables[0].Rows[0]["联系方式"].ToString().Trim();
                client.ClientState = ds.Tables[0].Rows[0]["客户状态"].ToString().Trim();
                client.ClientDescription = ds.Tables[0].Rows[0]["客户描述"].ToString().Trim();
                return client;
            }
            else
            { return null; }
        }
        /// <summary>
        /// 通过客户类代码获取一个客户的数据集，null 表示没有任何记录
        /// </summary>
        /// <param name="_clientTypeCode"></param>
        /// <returns></returns>
        public DataSet SelectData_3(string _clientTypeCode)
        {
            StringBuilder selectStr = new StringBuilder();
            selectStr.Append("Select * from Kehu");
            selectStr.Append("Where 客户类代码 = '");
            selectStr.Append(_clientTypeCode);
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
        /// <param name="_client"></param>
        /// <returns></returns>
        public bool AddData(Renting_Management_System.Models.ClientMod _client)
        {
            client = new Renting_Management_System.Models.ClientMod();
            client = SelectData_1(_client.ClientID);
            if (client == null)
            {
                StringBuilder insertStr = new StringBuilder();
                insertStr.Append("Insert Into Kehu");
                insertStr.Append("(客户编号,客户类代码,客户名称,性别,出生日期,证件类代码,证件号码,客户地址,联系方式,客户状态,客户描述)");
                insertStr.Append("Values ('");
                insertStr.Append(client.ClientID + "','");
                insertStr.Append(client.ClientTypeCode + "','");
                insertStr.Append(client.ClientName + "','");
                insertStr.Append(client.Sex + "',");
                insertStr.Append(client.BirthDate.ToShortDateString() + ",'");
                insertStr.Append(client.CertificateTypeCode + "','");
                insertStr.Append(client.CertificateNumber + "','");
                insertStr.Append(client.ClientAddress + "','");
                insertStr.Append(client.ClientContact + "','");
                insertStr.Append(client.ClientState + "','");
                insertStr.Append(client.ClientDescription);
                insertStr("')");
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
        /// <param name="_client"></param>
        /// <returns></returns>
        public bool ModifyData(Renting_Management_System.Models.ClientMod _client)
        {
            client = new Renting_Management_System.Models.ClientMod();
            client = SelectData_1(_client.ClientID);
            if (client != null)
            {
                StringBuilder updateStr = new StringBuilder();
                updateStr.Append("Update Kehu ");
                updateStr.Append("Set ");
                updateStr.Append("客户类代码 = '");
                updateStr.Append(client.ClientTypeCode + "'");
                updateStr.Append(",客户名称 = '");
                updateStr.Append(client.ClientName + "'");
                updateStr.Append(",性别 = '");
                updateStr.Append(client.Sex + "'");
                updateStr.Append(",出生日期 = ");
                updateStr.Append(client.BirthDate.ToShortDateString());
                updateStr.Append(",证件类代码 = '");
                updateStr.Append(client.CertificateTypeCode + "'");
                updateStr.Append(",证件号码 = '");
                updateStr.Append(client.CertificateNumber + "'");
                updateStr.Append(",客户地址 = '");
                updateStr.Append(client.ClientAddress + "'");
                updateStr.Append(",联系方式 = '");
                updateStr.Append(client.ClientContact + "'");
                updateStr.Append(",客户状态 = '");
                updateStr.Append(client.ClientState + "'");
                updateStr.Append(",客户描述 = '");
                updateStr.Append(client.ClientDescription + "'");
                updateStr.Append("Where 客户编号 = '");
                updateStr.Append(client.ClientID + "'");
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
        /// <param name="_client"></param>
        /// <returns></returns>
        public bool DeleteData(Renting_Management_System.Models.ClientMod _client)
        {
            client = new Renting_Management_System.Models.ClientMod();
            client = SelectData_1(_client.ClientID);
            if (client != null)
            {
                StringBuilder deleteStr = new StringBuilder();
                deleteStr.Append("Delete From Kehu");
                deleteStr.Append("Where 客户编号 = '");
                deleteStr.Append(client.ClientID);
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
