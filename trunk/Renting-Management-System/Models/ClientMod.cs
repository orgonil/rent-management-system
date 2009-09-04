using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Renting_Management_System.Models
{
    class ClientMod
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
        private string _clientTypeCode;
        /// <summary>
        /// 客户类代码
        /// </summary>
        public string ClientTypeCode
        {
            get { return _clientTypeCode; }
            set { _clientTypeCode = value; }
        }
        private string _clientName;
        /// <summary>
        /// 客户名称
        /// </summary>
        public string ClientName
        {
            get { return _clientName; }
            set { _clientName = value; }
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
        private string _clientAddress;
        /// <summary>
        /// 客户地址
        /// </summary>
        public string ClientAddress
        {
            get { return _clientAddress; }
            set { _clientAddress = value; }
        }
        private string _clientContact;
        /// <summary>
        /// 客户联系
        /// </summary>
        public string ClientContact
        {
            get { return _clientContact; }
            set { _clientContact = value; }
        }
        private string _clientState;
        /// <summary>
        /// 客户状态
        /// </summary>
        public string ClientState
        {
            get { return _clientState; }
            set { _clientState = value; }
        }
        private string _clientDescription;
        /// <summary>
        /// 客户描述
        /// </summary>
        public string ClientDescription
        {
            get { return _clientDescription; }
            set { _clientDescription = value; }
        }
    }
}
