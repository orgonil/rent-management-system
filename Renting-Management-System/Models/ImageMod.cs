using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Renting_Management_System.Models
{
    class ImageMod
    {
        private string _imageID;
        /// <summary>
        /// 影响编号
        /// </summary>
        public string ImageID
        {
            get { return _imageID; }
            set { _imageID = value; }
        }
        private string _imageName;
        /// <summary>
        /// 影像名称
        /// </summary>
        public string ImageName
        {
            get { return _imageName; }
            set { _imageName = value; }
        }
        private string _userID;
        /// <summary>
        /// 用户编号
        /// </summary>
        public string UserID
        {
            get { return _userID; }
            set { _userID = value; }
        }
        private string _imageTypeCode;
        /// <summary>
        /// 影像类代码
        /// </summary>
        public string ImageTypeCode
        {
            get { return _imageTypeCode; }
            set { _imageTypeCode = value; }
        }
        private string _localCode;
        /// <summary>
        /// 地点代码
        /// </summary>
        public string LocalCode
        {
            get { return _localCode; }
            set { _localCode = value; }
        }
        private int _imageCostPrice;
        /// <summary>
        /// 影像原价
        /// </summary>
        public int ImageCostPrice
        {
            get { return _imageCostPrice; }
            set { _imageCostPrice = value; }
        }
        private int _imageRentalPrice;
        /// <summary>
        /// 影像租价
        /// </summary>
        public int ImageRentalPrice
        {
            get { return _imageRentalPrice; }
            set { _imageRentalPrice = value; }
        }
        private int _storageQuantity;
        /// <summary>
        /// 创库存量
        /// </summary>
        public int StorageQuantity
        {
            get { return _storageQuantity; }
            set { _storageQuantity = value; }
        }
        private string _shelvesNumber;
        /// <summary>
        /// 货架编号
        /// </summary>
        public string ShelvesNumber
        {
            get { return _shelvesNumber; }
            set { _shelvesNumber = value; }
        }
        private string _rentState;
        /// <summary>
        /// 出租状态
        /// </summary>
        public string RentState
        {
            get { return _rentState; }
            set { _rentState = value; }
        }
        private string _imageDescription;
        /// <summary>
        /// 影像描述
        /// </summary>
        public string ImageDescription
        {
            get { return _imageDescription; }
            set { _imageDescription = value; }
        }
    }
}
