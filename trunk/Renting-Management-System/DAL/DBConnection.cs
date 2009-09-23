using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Renting_Management_System.DAL
{
    class DBConnection
    {
        private string stringConnection = @"Data Source=RINROTA-PC\RINROTA;AttachDbFilename=D:\My Project\Renting-Management-System\DataBase\Rent-Management-System.mdf;Integrated Security=True";
        private SqlConnection conn;
        private SqlCommand com;
        public DBConnection()
        {
            conn = new SqlConnection();
            conn.ConnectionString = stringConnection;
        }
        /// <summary>
        /// selectString 是 SQL Select 语句
        /// </summary>
        /// <param name="selectString"></param>
        /// <returns></returns>
        public DataSet SelectQuery(string selectString)
        {
            conn.Open();
            com = new SqlCommand(selectString, conn);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Close();
            return ds;
        }
        /// <summary>
        /// updateString 是 SQL 修改数据语句
        /// </summary>
        /// <param name="updateString"></param>
        public void UpdateQuery(string updateString)
        {
            conn.Open();
            com = new SqlCommand(updateString, conn);
            com.ExecuteNonQuery();
            conn.Close();
        }
        /// <summary>
        /// deleteString 是SQL删除数据语句
        /// </summary>
        /// <param name="deleteString"></param>
        public void DeleteQuery(string deleteString)
        {
            conn.Open();
            com = new SqlCommand(deleteString, conn);
            com.ExecuteNonQuery();
            conn.Close();
        }
        /// <summary>
        /// insertString 是SQL插入数据语句
        /// </summary>
        /// <param name="insertString"></param>
        public void InsertQuery(string insertString)
        {
            conn.Open();
            com = new SqlCommand(insertString, conn);
            com.ExecuteNonQuery();
            conn.Close();
        }
        /// <summary>
        /// 更新数据集，tableName 为数据表名称
        /// </summary>
        /// <param name="selectString"></param>
        public void Refresh(DataSet ds)
        {
            conn.Open();
            com = new SqlCommand("Select * From [" + ds.Tables[0].TableName + "]", conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = com;
            SqlCommandBuilder cb = new SqlCommandBuilder(dataAdapter);
            dataAdapter.Update(ds, ds.Tables[0].TableName);
            conn.Close();
        }
    }
}
