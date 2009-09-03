using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Renting_Management_System.Models
{
    class LocalMod
    {
        private string _localCode;
        /// <summary>
        /// 地点代码
        /// </summary>
        public string LocalCode
        {
            get { return _localCode; }
            set { _localCode = value; }
        }
        private string _localName;
        /// <summary>
        /// 地点名称
        /// </summary>
        public string LocalName
        {
            get { return _localName; }
            set { _localName = value; }
        }

    }
}
