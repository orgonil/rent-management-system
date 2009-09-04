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
        public DataSet GetAll()
        {
            DataSet ds = new DataSet();
            da = new DBConnection();
            ds = da.SelectQuery("Select * From Zujie");
            return ds;
        }
        public DataSet SelectData_1(string _clientID)
        {
            StringBuilder selectStr = new StringBuilder();
            selectStr.Append("Select * From Zujie");
            selectStr.Append("Where 客户编号 = '");
            selectStr.Append(_clientID);
            selectStr.Append("'");
            da = new DBConnection();
            DataSet ds = new DataSet();
            ds = da.SelectQuery(selectStr.ToString());
            if (ds.Tables.Count == 0)
            { return null; }
            else
            { return ds; }
        }
        public DataSet SelectData_2(string _imageID)
        {
            StringBuilder selectStr = new StringBuilder();
            selectStr.Append("Select * From Zujie");
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
        public DataSet SelectData_3(string _userID)
        {
            StringBuilder selectStr = new StringBuilder();
            selectStr.Append("Select * From Zujie");
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
        public Renting_Management_System.Models.RentMod SelectData_4(string _clientID, string _imageID)
        {
            StringBuilder selectStr = new StringBuilder();
            selectStr.Append("Select * From Zujie");
            selectStr.Append("Where 客户编号 = '");
            selectStr.Append(_clientID);
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
                rent.ClientID = ds.Tables[0].Rows[0]["客户编号"].ToString().Trim();
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
        public bool AddData(Renting_Management_System.Models.RentMod _rent)
        {
            rent = new Renting_Management_System.Models.RentMod();
            rent = SelectData_4(_rent.ClientID, _rent.ImageID);
            if (rent == null)
            {
                StringBuilder insertStr = new StringBuilder();
                insertStr.Append("Insert Into Zujie(影像编号,客户编号,用户编号,出租数量,出租日期,归还日期,出租押金,归还状态,描述)");
                insertStr.Append("Values ('");
                insertStr.Append(rent.ImageID + "','");
                insertStr.Append(rent.ClientID + "','");
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
        public bool ModifyData(Renting_Management_System.Models.RentMod _rent)
        {
            rent = new Renting_Management_System.Models.RentMod();
            rent = SelectData_4(_rent.ClientID, _rent.ImageID);
            if (rent != null)
            {
                StringBuilder updateStr = new StringBuilder();
                updateStr.Append("Update Zujie");
                updateStr.Append("Set ");

            }
        }
        public bool DeletData(Renting_Management_System.Models.RentMod _rent)
        { }
    }
}
