using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Renting_Management_System.Models
{
    class RentMod
    {
        private string _clientID;
        /// <summary>
        /// 客户编号
        /// </summary>
        public string ClientID
        {
            get { return _clientID; }
            set { _clientID = value; }
        }
        private string _ImageID;
        /// <summary>
        /// 影像编号
        /// </summary>
        public string ImageID
        {
            get { return _ImageID; }
            set { _ImageID = value; }
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
        private int _quantityOfRent;
        /// <summary>
        /// 出租数量
        /// </summary>
        public int QuantityOfRent
        {
            get { return _quantityOfRent; }
            set { _quantityOfRent = value; }
        }
        private DateTime _rentDate;
        /// <summary>
        /// 出租日期
        /// </summary>
        public DateTime RentDate
        {
            get { return _rentDate; }
            set { _rentDate = value; }
        }
        private DateTime _returnDate;
        /// <summary>
        /// 归还日期
        /// </summary>
        public DateTime ReturnDate
        {
            get { return _returnDate; }
            set { _returnDate = value; }
        }
        private int _deposit;
        /// <summary>
        /// 押金
        /// </summary>
        public int Deposit
        {
            get { return _deposit; }
            set { _deposit = value; }
        }
        private string _returnState;
        /// <summary>
        /// 归还状态
        /// </summary>
        public string ReturnState
        {
            get { return _returnState; }
            set { _returnState = value; }
        }
        private string _description;
        /// <summary>
        /// 描述
        /// </summary>
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
    }
}
