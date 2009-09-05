using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Renting_Management_System.Models
{
    class CustomerMod
    {
        private string _customerID;
        /// <summary>
        /// 客户编号
        /// </summary>
        public string CustomerID
        {
            get { return _customerID; }
            set { _customerID = value; }
        }
        private string _customerTypeCode;
        /// <summary>
        /// 客户类代码
        /// </summary>
        public string CustomerTypeCode
        {
            get { return _customerTypeCode; }
            set { _customerTypeCode = value; }
        }
        private string _customerName;
        /// <summary>
        /// 客户名称
        /// </summary>
        public string CustomerName
        {
            get { return _customerName; }
            set { _customerName = value; }
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
        private string _customerAddress;
        /// <summary>
        /// 客户地址
        /// </summary>
        public string CustomerAddress
        {
            get { return _customerAddress; }
            set { _customerAddress = value; }
        }
        private string _customerContact;
        /// <summary>
        /// 客户联系
        /// </summary>
        public string CustomerContact
        {
            get { return _customerContact; }
            set { _customerContact = value; }
        }
        private string _customerState;
        /// <summary>
        /// 客户状态
        /// </summary>
        public string CustomerState
        {
            get { return _customerState; }
            set { _customerState = value; }
        }
        private string _customerDescription;
        /// <summary>
        /// 客户描述
        /// </summary>
        public string CustomerDescription
        {
            get { return _customerDescription; }
            set { _customerDescription = value; }
        }
    }
}
