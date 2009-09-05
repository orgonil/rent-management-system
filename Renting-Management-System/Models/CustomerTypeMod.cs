using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Renting_Management_System.Models
{
    class CustomerTypeMod
    {
        private string _customerTypeCode;
        /// <summary>
        /// 客户类代码
        /// </summary>
        public string CustomerTypeCode
        {
            get { return _customerTypeCode; }
            set { _customerTypeCode = value; }
        }
        private string _customerTypeName;
        /// <summary>
        /// 客户类名称
        /// </summary>
        public string CustomerTypeName
        {
            get { return _customerTypeName; }
            set { _customerTypeName = value; }
        }
    }
}
