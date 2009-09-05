using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Renting_Management_System.DAL
{
    class ImageTypeDAL
    {
        public Renting_Management_System.Models.ImageTypeMod type;
        public Renting_Management_System.DAL.DBConnection da;
        /// <summary>
        /// 获取所有数据，整个表的记录
        /// </summary>
        /// <returns></returns>
        public DataSet GetAll()
        {
            da = new DBConnection();
            DataSet ds = new DataSet();
            ds = da.SelectQuery("Select * from ImageType");
            return ds;
        }
        /// <summary>
        /// 获取一个影像类
        /// </summary>
        /// <param name="_userTypeCode"></param>
        /// <returns></returns>
        public Renting_Management_System.Models.ImageTypeMod SelectData(string _imageTypeCode)
        {
            type = new Renting_Management_System.Models.ImageTypeMod();
            type.ImageTypeCode = _imageTypeCode;
            da = new DBConnection();
            DataSet ds = new DataSet();
            StringBuilder selectStr = new StringBuilder();
            selectStr.Append("Select * From ImageType");
            selectStr.Append("Where 影类代码 = '");
            selectStr.Append(type.ImageTypeCode);
            selectStr.Append("'");
            ds = da.SelectQuery(selectStr.ToString());
            if (ds.Tables.Count == 0)
            {
                return null;
            }
            else
            {
                type.ImageTypeCode = ds.Tables[0].Rows[0]["影类代码"].ToString().Trim();
                type.ImageTypeName = ds.Tables[0].Rows[0]["影类名称"].ToString().Trim();
                return type;
            }
        }
        /// <summary>
        /// 删除一个影类
        /// 返回 true 表示成功；
        /// 返回 false 表示该类不存在
        /// </summary>
        /// <param name="uType"></param>
        /// <returns></returns>
        public bool DeleteData(Renting_Management_System.Models.ImageTypeMod iType)
        {
            type = new Renting_Management_System.Models.ImageTypeMod(); 
            type = SelectData(iType.ImageTypeCode);
            if (type != null)
            {
                da = new DBConnection();
                StringBuilder deleteStr = new StringBuilder();
                deleteStr.Append("Delete From ImageType");
                deleteStr.Append("Where 影类代码 = '");
                deleteStr.Append(type.ImageTypeCode);
                deleteStr.Append("'");
                da.DeleteQuery(deleteStr.ToString());
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// 修改一个影类名称
        /// 返回 true 表示成功
        /// 返回 false 表示该类不存在
        /// </summary>
        /// <param name="uType"></param>
        /// <returns></returns>
        public bool ModifyData(Renting_Management_System.Models.ImageTypeMod iType)
        {
            type = new Renting_Management_System.Models.ImageTypeMod(); 
            type = SelectData(iType.ImageTypeCode);
            if (type != null)
            {
                da = new DBConnection();
                StringBuilder modifyStr = new StringBuilder();
                modifyStr.Append("Update ImageType");
                modifyStr.Append("Set 影类名称 = '");
                modifyStr.Append(type.ImageTypeName + "'");
                modifyStr.Append("Where 影类代码 = '");
                modifyStr.Append(type.ImageTypeCode + "'");
                da.UpdateQuery(modifyStr.ToString());
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// 添加一个影类
        /// 返回 true 表示成功
        /// 返回 false 表示数据已存在
        /// </summary>
        /// <param name="uType"></param>
        /// <returns></returns>
        public bool AddData(Renting_Management_System.Models.ImageTypeMod iType)
        {
            type = new Renting_Management_System.Models.ImageTypeMod(); 
            type = SelectData(iType.ImageTypeCode);
            if (type == null)
            {
                da = new DBConnection();
                StringBuilder insertStr = new StringBuilder();
                insertStr.Append("Insert Into ImageType (影类代码,影类名称)");
                insertStr.Append("Values ('");
                insertStr.Append(type.ImageTypeCode + "','");
                insertStr.Append(type.ImageTypeName);
                insertStr.Append("')");
                da.InsertQuery(insertStr.ToString());
                return true;
            }
            else
                return false;
        }
    }
}
