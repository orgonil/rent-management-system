using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Renting_Management_System.DAL
{
    class ImageDAL
    {
        private Renting_Management_System.Models.ImageMod image;
        private Renting_Management_System.DAL.DBConnection da;
        /// <summary>
        /// 获取所有数据，整个表的记录
        /// 返回一个数据集
        /// </summary>
        /// <returns></returns>
        public DataSet GetAll()
        {
            da = new DBConnection();
            DataSet ds = new DataSet();
            string selectStr = "Select * From [Image]";
            ds = da.SelectQuery(selectStr);
            return ds;
        }
        /// <summary>
        /// 更新数据集
        /// </summary>
        /// <param name="dataSet"></param>
        public void Update(DataSet dataSet)
        {
            da = new DBConnection();
            da.Refresh("[Image]", dataSet);
        }
        /// <summary>
        /// 通过影像编号获取一个影像的记录
        /// 返回 null 表示数据不存在，否侧返回一个影像的记录
        /// </summary>
        /// <param name="_imageID"></param>
        /// <returns></returns>
        public Renting_Management_System.Models.ImageMod SelectByID(string _imageID)
        {
            StringBuilder selectStr = new StringBuilder();
            selectStr.Append("Select * From [Image]");
            selectStr.Append("Where 影像编号 = '");
            selectStr.Append(_imageID);
            selectStr.Append("'");
            DataSet ds = new DataSet();
            da = new DBConnection();
            ds = da.SelectQuery(selectStr.ToString());
            if (ds.Tables.Count == 0)
            { return null; }
            else
            {
                image = new Renting_Management_System.Models.ImageMod();
                image.ImageID = ds.Tables[0].Rows[0]["影像编号"].ToString().Trim();
                image.ImageName = ds.Tables[0].Rows[0]["影像名称"].ToString().Trim();
                image.UserID = ds.Tables[0].Rows[0]["用户编号"].ToString().Trim();
                image.ImageTypeCode = ds.Tables[0].Rows[0]["影类代码"].ToString().Trim();
                image.LocalCode = ds.Tables[0].Rows[0]["地点代码"].ToString().Trim();
                image.ImageCostPrice = int.Parse(ds.Tables[0].Rows[0]["影像原价"].ToString().Trim());
                image.ImageRentalPrice = int.Parse(ds.Tables[0].Rows[0]["影像租价"].ToString().Trim());
                image.StorageQuantity = int.Parse(ds.Tables[0].Rows[0]["库存数量"].ToString().Trim());
                image.ShelvesNumber = ds.Tables[0].Rows[0]["货架号"].ToString().Trim();
                image.RentState = ds.Tables[0].Rows[0]["出租状态"].ToString().Trim();
                image.ImageDescription = ds.Tables[0].Rows[0]["影像描述"].ToString().Trim();
                return image;
            }
        }
        /// <summary>
        /// 通过影像名称获取一个影像的记录
        /// 返回 null 表示数据不存在，否侧返回一个影像的记录
        /// </summary>
        /// <param name="_imageName"></param>
        /// <returns></returns>
        public Renting_Management_System.Models.ImageMod SelectByName(string _imageName)
        {
            StringBuilder selectStr = new StringBuilder();
            selectStr.Append("Select * From [Image]");
            selectStr.Append("Where 影像名称 = '");
            selectStr.Append(_imageName);
            selectStr.Append("'");
            DataSet ds = new DataSet();
            da = new DBConnection();
            ds = da.SelectQuery(selectStr.ToString());
            if (ds.Tables.Count == 0)
            { return null; }
            else
            {
                image = new Renting_Management_System.Models.ImageMod();
                image.ImageID = ds.Tables[0].Rows[0]["影像编号"].ToString().Trim();
                image.ImageName = ds.Tables[0].Rows[0]["影像名称"].ToString().Trim();
                image.UserID = ds.Tables[0].Rows[0]["用户编号"].ToString().Trim();
                image.ImageTypeCode = ds.Tables[0].Rows[0]["影类代码"].ToString().Trim();
                image.LocalCode = ds.Tables[0].Rows[0]["地点代码"].ToString().Trim();
                image.ImageCostPrice = int.Parse(ds.Tables[0].Rows[0]["影像原价"].ToString().Trim());
                image.ImageRentalPrice = int.Parse(ds.Tables[0].Rows[0]["影像租价"].ToString().Trim());
                image.StorageQuantity = int.Parse(ds.Tables[0].Rows[0]["库存数量"].ToString().Trim());
                image.ShelvesNumber = ds.Tables[0].Rows[0]["货架号"].ToString().Trim();
                image.RentState = ds.Tables[0].Rows[0]["出租状态"].ToString().Trim();
                image.ImageDescription = ds.Tables[0].Rows[0]["影像描述"].ToString().Trim();
                return image;
            }
        }
        /// <summary>
        /// 通过影像类型获取数据
        /// 返回 null 表示没有数据，否侧返回一个影像的数据集
        /// </summary>
        /// <param name="_imageTypeCode"></param>
        /// <returns></returns>
        public DataSet SelectByTypeCode(string _imageTypeCode)
        {
            StringBuilder selectStr = new StringBuilder();
            selectStr.Append("Select * From [Image]");
            selectStr.Append("Where 影类代码 = '");
            selectStr.Append(_imageTypeCode);
            selectStr.Append("'");
            DataSet ds = new DataSet();
            da = new DBConnection();
            ds = da.SelectQuery(selectStr.ToString());
            if (ds.Tables.Count == 0)
            { return null; }
            else
            { return ds; }
        }
        /// <summary>
        /// 通过用户编号获取影像数据
        /// 返回 null 表示没有数据，否侧返回一个影像的数据集
        /// </summary>
        /// <param name="_userID"></param>
        /// <returns></returns>
        public DataSet SelectByUserID(string _userID)
        {
            StringBuilder selectStr = new StringBuilder();
            selectStr.Append("Select * From [Image]");
            selectStr.Append("Where 用户编号 = '");
            selectStr.Append(_userID);
            selectStr.Append("'");
            DataSet ds = new DataSet();
            da = new DBConnection();
            ds = da.SelectQuery(selectStr.ToString());
            if (ds.Tables.Count == 0)
            { return null; }
            else
            {
                return ds;
            }
        }
        /// <summary>
        /// 添加一个影像的信息
        /// 返回 true 表示成功，否侧该影像已存在
        /// </summary>
        /// <param name="_image"></param>
        /// <returns></returns>
        public bool AddData(Renting_Management_System.Models.ImageMod _image)
        {
            image = new Renting_Management_System.Models.ImageMod();
            image = SelectByID(_image.ImageID);
            if (image != null)
            { return false; }
            else
            {
                StringBuilder insertStr = new StringBuilder();
                insertStr.Append("Insert Into [Image] (影像编号,影像名称,用户编号,影类代码,地点代码,影像原价,影像租价,库存数量,货架号,出租状态,影像描述)");
                insertStr.Append("Values ('");
                insertStr.Append(image.ImageID + "','");
                insertStr.Append(image.ImageName + "','");
                insertStr.Append(image.UserID + "','");
                insertStr.Append(image.ImageTypeCode + "','");
                insertStr.Append(image.LocalCode + "',");
                insertStr.Append(image.ImageCostPrice + ",");
                insertStr.Append(image.ImageRentalPrice + ",");
                insertStr.Append(image.StorageQuantity + ",'");
                insertStr.Append(image.ShelvesNumber + "','");
                insertStr.Append(image.RentState + "','");
                insertStr.Append(image.ImageDescription);
                insertStr.Append("')");
                da = new DBConnection();
                da.InsertQuery(insertStr.ToString());
                return true;
            }
        }
        /// <summary>
        /// 修改一个影像的记录
        /// 返回 true 表示成功，否侧数据不存在
        /// </summary>
        /// <param name="_image"></param>
        /// <returns></returns>
        public bool ModifyData(Renting_Management_System.Models.ImageMod _image)
        {
            image = new Renting_Management_System.Models.ImageMod();
            image = SelectByID(_image.ImageID);
            if (image == null)
            { return false; }
            else
            {
                StringBuilder updateStr = new StringBuilder();
                updateStr.Append("Update [Image] ");
                updateStr.Append("Set ");
                updateStr.Append("影像名称 = '");
                updateStr.Append(image.ImageName);
                updateStr.Append("',用户编号 = '");
                updateStr.Append(image.UserID);
                updateStr.Append("',影类代码 = '");
                updateStr.Append(image.ImageTypeCode);
                updateStr.Append("',地点代码 = '");
                updateStr.Append(image.LocalCode);
                updateStr.Append("',影像原价 = ");
                updateStr.Append(image.ImageCostPrice);
                updateStr.Append(",影像租价 = ");
                updateStr.Append(image.ImageRentalPrice);
                updateStr.Append(",库存数量 = ");
                updateStr.Append(image.StorageQuantity);
                updateStr.Append(",货架号 = '");
                updateStr.Append(image.ShelvesNumber);
                updateStr.Append("',出租状态 = '");
                updateStr.Append(image.RentState);
                updateStr.Append("',影像描述 = '");
                updateStr.Append(image.ImageDescription);
                updateStr.Append("'");
                updateStr.Append("Where 影像编号 = '");
                updateStr.Append(image.ImageID);
                updateStr.Append("'");
                da = new DBConnection();
                da.UpdateQuery(updateStr.ToString());
                return true;
            }
        }
        /// <summary>
        /// 删除一个影像
        /// 返回 true 表示成功，否侧数据不存在
        /// </summary>
        /// <param name="_image"></param>
        /// <returns></returns>
        public bool DeleteData(Renting_Management_System.Models.ImageMod _image)
        {
            image = new Renting_Management_System.Models.ImageMod();
            image = SelectByID(_image.ImageID);
            if (image == null)
            { return false; }
            else
            {
                StringBuilder deleteStr = new StringBuilder();
                deleteStr.Append("Delete From [Image]");
                deleteStr.Append("Where 影像编号 = '");
                deleteStr.Append(image.ImageID);
                deleteStr.Append("'");
                da = new DBConnection();
                da.DeleteQuery(deleteStr.ToString());
                return true;
            }
        }
    }
}
