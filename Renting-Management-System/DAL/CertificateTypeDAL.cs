using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Renting_Management_System.DAL
{
    class CertificateTypeDAL
    {
        public Renting_Management_System.Models.CertificateTypeMod type;
        public Renting_Management_System.DAL.DBConnection da;
        /// <summary>
        /// 获取所有数据，整个表
        /// </summary>
        /// <returns></returns>
        public DataSet GetAll()
        {
            da = new DBConnection();
            DataSet ds = new DataSet();
            ds = da.SelectQuery("Select * from [CertificateType]");
            return ds;
        }
        /// <summary>
        /// 更新数据集
        /// </summary>
        /// <param name="dataSet"></param>
        public void Update(DataSet dataSet)
        {
            da = new DBConnection();
            da.Refresh("[CertificateType]", dataSet);
        }
        /// <summary>
        /// 获取一个证件类
        /// </summary>
        /// <param name="_userTypeCode"></param>
        /// <returns></returns>
        public Renting_Management_System.Models.CertificateTypeMod SelectData(string _certificateCode)
        {
            type = new Renting_Management_System.Models.CertificateTypeMod();
            type.CertificateTypeCode = _certificateCode;
            da = new DBConnection();
            DataSet ds = new DataSet();
            StringBuilder selectStr = new StringBuilder();
            selectStr.Append("Select * From [CertificateType]");
            selectStr.Append("Where 证件类代码 = '");
            selectStr.Append(type.CertificateTypeCode);
            selectStr.Append("'");
            ds = da.SelectQuery(selectStr.ToString());
            if (ds.Tables.Count == 0)
            {
                return null;
            }
            else
            {
                type.CertificateTypeCode = ds.Tables[0].Rows[0]["证件类代码"].ToString().Trim();
                type.CertificateTypeName = ds.Tables[0].Rows[0]["证件类名称"].ToString().Trim();
                return type;
            }
        }
        /// <summary>
        /// 删除一个证件类
        /// 返回 true 表示成功；
        /// 返回 false 表示该类不存在
        /// </summary>
        /// <param name="uType"></param>
        /// <returns></returns>
        public bool DeleteData(Renting_Management_System.Models.CertificateTypeMod _certificateType)
        {
            type = new Renting_Management_System.Models.CertificateTypeMod();
            type = SelectData(_certificateType.CertificateTypeCode);
            if (type != null)
            {
                da = new DBConnection();
                StringBuilder deleteStr = new StringBuilder();
                deleteStr.Append("Delete From [CertificateType]");
                deleteStr.Append("Where 证件类代码 = '");
                deleteStr.Append(type.CertificateTypeCode);
                deleteStr.Append("'");
                da.DeleteQuery(deleteStr.ToString());
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// 修改一个证件类名称
        /// 返回 true 表示成功
        /// 返回 false 表示该类不存在
        /// </summary>
        /// <param name="uType"></param>
        /// <returns></returns>
        public bool ModifyData(Renting_Management_System.Models.CertificateTypeMod _certificateType)
        {
            type = new Renting_Management_System.Models.CertificateTypeMod();
            type = SelectData(_certificateType.CertificateTypeCode);
            if (type != null)
            {
                da = new DBConnection();
                StringBuilder modifyStr = new StringBuilder();
                modifyStr.Append("Update [CertificateType]");
                modifyStr.Append("Set 证件类名称 = '");
                modifyStr.Append(type.CertificateTypeName + "'");
                modifyStr.Append("Where 证件类代码 = '");
                modifyStr.Append(type.CertificateTypeCode + "'");
                da.UpdateQuery(modifyStr.ToString());
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// 添加一个证件类型
        /// 返回 true 表示成功
        /// 返回 false 表示数据已存在
        /// </summary>
        /// <param name="uType"></param>
        /// <returns></returns>
        public bool AddData(Renting_Management_System.Models.CertificateTypeMod _certificateType)
        {
            type = new Renting_Management_System.Models.CertificateTypeMod();
            type = SelectData(_certificateType.CertificateTypeCode);
            if (type == null)
            {
                da = new DBConnection();
                StringBuilder insertStr = new StringBuilder();
                insertStr.Append("Insert Into [CertificateType] (证件类代码,证件类名称)");
                insertStr.Append("Values ('");
                insertStr.Append(type.CertificateTypeCode + "','");
                insertStr.Append(type.CertificateTypeName);
                insertStr.Append("')");
                da.InsertQuery(insertStr.ToString());
                return true;
            }
            else
                return false;
        }
    }
}
