using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Renting_Management_System.DAL
{
    class RentDAL
    {
        public Renting_Management_System.Models.RentMod rent;
        public Renting_Management_System.DAL.DBConnection da;
        /// <summary>
        /// 获取所有租借记录，整个表的数据集
        /// 返回一个数据集
        /// </summary>
        /// <returns></returns>
        public DataSet GetAll()
        {
            DataSet ds = new DataSet();
            da = new DBConnection();
            ds = da.SelectQuery("Select * From [Rent]");
            return ds;
        }
        /// <summary>
        /// 更新数据集
        /// </summary>
        /// <param name="dataSet"></param>
        public void Update(DataSet dataSet)
        {
            da = new DBConnection();
            da.Refresh("[Rent]", dataSet);
        }
        /// <summary>
        /// 通过客户编号获取一个租借记录的数据集
        /// 返回 null 表示记录不存在，否侧返回一个租借记录的数据集
        /// </summary>
        /// <param name="_customerID"></param>
        /// <returns></returns>
        public DataSet SelectByCustomerID(string _customerID)
        {
            StringBuilder selectStr = new StringBuilder();
            selectStr.Append("Select * From [Rent]");
            selectStr.Append("Where 客户编号 = '");
            selectStr.Append(_customerID);
            selectStr.Append("'");
            da = new DBConnection();
            DataSet ds = new DataSet();
            ds = da.SelectQuery(selectStr.ToString());
            if (ds.Tables.Count == 0)
            { return null; }
            else
            { return ds; }
        }
        /// <summary>
        /// 通过影像编号获取一个租借记录的数据集
        /// 返回 null 表示记录不存在，否侧返回一个租借记录的数据集
        /// </summary>
        /// <param name="_imageID"></param>
        /// <returns></returns>
        public DataSet SelectByImageID(string _imageID)
        {
            StringBuilder selectStr = new StringBuilder();
            selectStr.Append("Select * From [Rent]");
            selectStr.Append("Where 影像编号 = '");
            selectStr.Append(_imageID);
            selectStr.Append("'");
            da = new DBConnection();
            DataSet ds = new DataSet();
            ds = da.SelectQuery(selectStr.ToString());
            if (ds.Tables.Count == 0)
            { return null; }
            else
            { return ds; }
        }
        /// <summary>
        /// 通过用户编号获取一个租借记录的数据集
        /// 返回 null 表示记录不存在，否侧返回一个租借记录的数据集
        /// </summary>
        /// <param name="_userID"></param>
        /// <returns></returns>
        public DataSet SelectByUserID(string _userID)
        {
            StringBuilder selectStr = new StringBuilder();
            selectStr.Append("Select * From [Rent]");
            selectStr.Append("Where 用户编号 = '");
            selectStr.Append(_userID);
            selectStr.Append("'");
            da = new DBConnection();
            DataSet ds = new DataSet();
            ds = da.SelectQuery(selectStr.ToString());
            if (ds.Tables.Count == 0)
            { return null; }
            else
            { return ds; }
        }
        /// <summary>
        /// 通过客户编号和影像编号，获取一个租借记录
        /// 返回 null 表示记录不存在，否侧返回一个租借的记录
        /// </summary>
        /// <param name="_customerID"></param>
        /// <param name="_imageID"></param>
        /// <returns></returns>
        public Renting_Management_System.Models.RentMod SelectBy_CustomerID_N_ImageID(string _customerID, string _imageID)
        {
            StringBuilder selectStr = new StringBuilder();
            selectStr.Append("Select * From [Rent]");
            selectStr.Append("Where 客户编号 = '");
            selectStr.Append(_customerID);
            selectStr.Append("' And 影像编号 = '");
            selectStr.Append(_imageID);
            selectStr.Append("'");
            da = new DBConnection();
            DataSet ds = new DataSet();
            ds = da.SelectQuery(selectStr.ToString());
            if (ds.Tables.Count == 0)
            { return null; }
            else
            {
                rent = new Renting_Management_System.Models.RentMod();
                rent.ImageID = ds.Tables[0].Rows[0]["影像编号"].ToString().Trim();
                rent.CustomerID = ds.Tables[0].Rows[0]["客户编号"].ToString().Trim();
                rent.UserID = ds.Tables[0].Rows[0]["用户编号"].ToString().Trim();
                rent.QuantityOfRent = int.Parse(ds.Tables[0].Rows[0]["影像编号"].ToString().Trim());
                rent.RentDate = DateTime.Parse(ds.Tables[0].Rows[0]["出租日期"].ToString().Trim());
                rent.ReturnDate = DateTime.Parse(ds.Tables[0].Rows[0]["归还日期"].ToString().Trim());
                rent.Deposit = int.Parse(ds.Tables[0].Rows[0]["出租押金"].ToString().Trim());
                rent.ReturnState = ds.Tables[0].Rows[0]["归还状态"].ToString().Trim();
                rent.Description = ds.Tables[0].Rows[0]["描述"].ToString().Trim();
                return rent;
            }
        }
        /// <summary>
        /// 添加一个租借的记录
        /// 返回 true 表示成功，否侧该记录已存在
        /// </summary>
        /// <param name="_rent"></param>
        /// <returns></returns>
        public bool AddData(Renting_Management_System.Models.RentMod _rent)
        {
            rent = new Renting_Management_System.Models.RentMod();
            rent =SelectBy_CustomerID_N_ImageID(_rent.CustomerID, _rent.ImageID);
            if (rent == null)
            {
                StringBuilder insertStr = new StringBuilder();
                insertStr.Append("Insert Into ]Rent](影像编号,客户编号,用户编号,出租数量,出租日期,归还日期,出租押金,归还状态,描述)");
                insertStr.Append("Values ('");
                insertStr.Append(rent.ImageID + "','");
                insertStr.Append(rent.CustomerID + "','");
                insertStr.Append(rent.UserID + "',");
                insertStr.Append(rent.QuantityOfRent + ",");
                insertStr.Append(rent.RentDate.ToShortDateString() + ",");
                insertStr.Append(rent.ReturnDate.ToShortDateString() + ",");
                insertStr.Append(rent.Deposit + ",'");
                insertStr.Append(rent.ReturnState + "','");
                insertStr.Append(rent.Description + "'");
                da = new DBConnection();
                da.InsertQuery(insertStr.ToString());
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 修改一个租借的记录
        /// 返回 true 表示成功，否侧该记录不存在
        /// </summary>
        /// <param name="_rent"></param>
        /// <returns></returns>
        public bool ModifyData(Renting_Management_System.Models.RentMod _rent)
        {
            rent = new Renting_Management_System.Models.RentMod();
            rent =SelectBy_CustomerID_N_ImageID(_rent.CustomerID, _rent.ImageID);
            if (rent != null)
            {
                StringBuilder updateStr = new StringBuilder();
                updateStr.Append("Update [Rent]");
                updateStr.Append("Set ");
                updateStr.Append("用户编号 = '");
                updateStr.Append(rent.UserID);
                updateStr.Append("',出租数量 = ");
                updateStr.Append(rent.QuantityOfRent);
                updateStr.Append(",出租日期 = ");
                updateStr.Append(rent.RentDate.ToShortDateString());
                updateStr.Append(",归还日期 = ");
                updateStr.Append(rent.ReturnDate.ToShortDateString());
                updateStr.Append(",出租押金 = ");
                updateStr.Append(rent.Deposit);
                updateStr.Append(",归还状态 = '");
                updateStr.Append(rent.ReturnState);
                updateStr.Append("',描述 = '");
                updateStr.Append(rent.Description);
                updateStr.Append("'");
                updateStr.Append("Where 客户编号 = '");
                updateStr.Append(rent.CustomerID);
                updateStr.Append("' And 影像编号 = '");
                updateStr.Append(rent.ImageID);
                updateStr.Append("'");
                da = new DBConnection();
                da.UpdateQuery(updateStr.ToString());
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 删除一个租借记录
        /// 返回 true 表示成功，否侧该记录不存在
        /// </summary>
        /// <param name="_rent"></param>
        /// <returns></returns>
        public bool DeletData(Renting_Management_System.Models.RentMod _rent)
        { 
            rent = new Renting_Management_System.Models.RentMod();
            rent =SelectBy_CustomerID_N_ImageID(_rent.CustomerID, _rent.ImageID);
            if (rent != null)
            {
                StringBuilder deleteStr = new StringBuilder();
                deleteStr.Append("Delete From [Rent]");
                deleteStr.Append("Where 客户编号 = '");
                deleteStr.Append(rent.CustomerID);
                deleteStr.Append("' And 影像编号 = '");
                deleteStr.Append(rent.ImageID);
                deleteStr.Append("'");
                da = new DBConnection();
                da.DeleteQuery(deleteStr.ToString());
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
