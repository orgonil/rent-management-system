using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Renting_Management_System.Models
{
    class ClientTypeMod
    {
        private string _clientTypeCode;
        /// <summary>
        /// 客户类代码
        /// </summary>
        public string ClientTypeCode
        {
            get { return _clientTypeCode; }
            set { _clientTypeCode = value; }
        }
        private string _clientTypeName;
        /// <summary>
        /// 客户类名称
        /// </summary>
        public string ClientTypeName
        {
            get { return _clientTypeName; }
            set { _clientTypeName = value; }
        }
    }
}
