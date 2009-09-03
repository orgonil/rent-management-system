using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Renting_Management_System.Models
{
    class UserTypeMod
    {
        private string _userTypeCode;
        /// <summary>
        /// 用户类代码
        /// </summary>
        public string UserTypeCode
        {
            get { return _userTypeCode; }
            set { _userTypeCode = value; }
        }
        private string _userTypeName;
        /// <summary>
        /// 用户类名称
        /// </summary>
        public string UserTypeName
        {
            get { return _userTypeName; }
            set { _userTypeName = value; }
        }
    }
}
