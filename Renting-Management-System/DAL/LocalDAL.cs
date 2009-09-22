using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Renting_Management_System.DAL
{
    class LocalDAL
    {
        private Renting_Management_System.Models.LocalMod local;
        private Renting_Management_System.DAL.DBConnection da;
        /// <summary>
        /// 获取所有数据、整个表的记录
        /// </summary>
        /// <returns></returns>
        public DataSet GetAll()
        {
            da = new DBConnection();
            DataSet ds = new DataSet();
            StringBuilder selectStr = new StringBuilder();
            selectStr.Append("Select * From [Local]");
            ds = da.SelectQuery(selectStr.ToString());
            ds.Tables[0].TableName = "Local";
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
        /// 获取一个地点
        /// _localCode 为地点代码
        /// </summary>
        /// <param name="_localCode"></param>
        /// <returns></returns>
        public Renting_Management_System.Models.LocalMod SelectData(string _localCode)
        {
            local = new Renting_Management_System.Models.LocalMod();
            local.LocalCode = _localCode;
            da = new DBConnection();
            DataSet ds = new DataSet();
            StringBuilder selectStr = new StringBuilder();
            selectStr.Append("Select * From [Local]");
            selectStr.Append("Where 地点代码 = '");
            selectStr.Append(local.LocalCode);
            selectStr.Append("'");
            ds = da.SelectQuery(selectStr.ToString());
            if (ds.Tables.Count == 0)
            {
                return null;
            }
            else
            {
                local.LocalCode = ds.Tables[0].Rows[0]["地点代码"].ToString().Trim();
                local.LocalName = ds.Tables[0].Rows[0]["地点名称"].ToString().Trim();
                return local;
            }

        }
        /// <summary>
        /// 修改一个地点名称
        /// 返回 true 表示成功
        /// 返回 false 表示数据不存在
        /// </summary>
        /// <param name="_local"></param>
        /// <returns></returns>
        public bool ModifyData(Renting_Management_System.Models.LocalMod _local)
        {
            local = new Renting_Management_System.Models.LocalMod();
            local = SelectData(_local.LocalCode);
            if (local != null)
            {
                da = new DBConnection();
                StringBuilder modifyStr = new StringBuilder();
                modifyStr.Append("Update [Local]");
                modifyStr.Append("Set 地点名称 = '");
                modifyStr.Append(local.LocalName);
                modifyStr.Append("'");
                modifyStr.Append("Where 地点代码 = '");
                modifyStr.Append(local.LocalCode);
                modifyStr.Append("'");
                da.UpdateQuery(modifyStr.ToString());
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// 删除一个地点
        /// 返回 true 表示成功
        /// 返回 false 表示数据不存在
        /// </summary>
        /// <param name="_local"></param>
        /// <returns></returns>
        public bool DeleteData(Renting_Management_System.Models.LocalMod _local)
        {
            local = new Renting_Management_System.Models.LocalMod();
            local = SelectData(_local.LocalCode);
            if (local != null)
            {
                da = new DBConnection();
                StringBuilder deleteStr = new StringBuilder();
                deleteStr.Append("Delete From [Local]");
                deleteStr.Append("'");
                deleteStr.Append("Where 地点代码 = '");
                deleteStr.Append(local.LocalCode);
                deleteStr.Append("'");
                da.DeleteQuery(deleteStr.ToString());
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// 添加一个地点
        /// 返回 true 表示成功
        /// 返回 false 表示数据已存在
        /// </summary>
        /// <param name="_local"></param>
        /// <returns></returns>
        public bool AddData(Renting_Management_System.Models.LocalMod _local)
        {
            local = new Renting_Management_System.Models.LocalMod();
            local = SelectData(_local.LocalCode);
            if (local == null)
            {
                da = new DBConnection();
                StringBuilder insertStr = new StringBuilder();
                insertStr.Append("Insert Into [Local] (地点代码,地点名称)");
                insertStr.Append("Values ('");
                insertStr.Append(local.LocalCode + "','");
                insertStr.Append(local.LocalName);
                insertStr.Append("')");
                da.InsertQuery(insertStr.ToString());
                return true;
            }
            else
                return false;
        }
    }
}
