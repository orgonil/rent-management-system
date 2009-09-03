using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Renting_Management_System.Models
{
    class UserMod
    {
        private string _userID;
        /// <summary>
        /// 用户编号
        /// </summary>
        public string UserID
        {
            get { return _userID; }
            set { _userID = value; }
        }
        private string _userName;
        /// <summary>
        /// 用户名称
        /// </summary>
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        private char _sex;
        /// <summary>
        /// 性别
        /// </summary>
        public char Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }
        private DateTime _birthDate;
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }
        private string _userPassword;
        /// <summary>
        /// 用户密码
        /// </summary>
        public string UserPassword
        {
            get { return _userPassword; }
            set { _userPassword = value; }
        }
        private string _userTypeCode;
        /// <summary>
        /// 用户类代码
        /// </summary>
        public string UserTypeCode
        {
            get { return _userTypeCode; }
            set { _userTypeCode = value; }
        }
        private string _certificateTypeCode;
        /// <summary>
        /// 证件类代码
        /// </summary>
        public string CertificateTypeCode
        {
            get { return _certificateTypeCode; }
            set { _certificateTypeCode = value; }
        }
        private string _certificateNumber;
        /// <summary>
        /// 证件号码
        /// </summary>
        public string CertificateNumber
        {
            get { return _certificateNumber; }
            set { _certificateNumber = value; }
        }
        private string _userContact;
        /// <summary>
        /// 联系方式
        /// </summary>
        public string UserContact
        {
            get { return _userContact; }
            set { _userContact = value; }
        }
        private string _userAddress;
        /// <summary>
        /// 用户地址
        /// </summary>
        public string UserAddress
        {
            get { return _userAddress; }
            set { _userAddress = value; }
        }
        private string _userDescription;
        /// <summary>
        /// 用户描述
        /// </summary>
        public string UserDescription
        {
            get { return _userDescription; }
            set { _userDescription = value; }
        }
    }
}
