using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Renting_Management_System.Models
{
    class CertificateTypeMod
    {
        private string _certificateTypeCode;
        /// <summary>
        /// 证件类代码
        /// </summary>
        public string CertificateTypeCode
        {
            get { return _certificateTypeCode; }
            set { _certificateTypeCode = value; }
        }
        private string _certificateTypeName;
        /// <summary>
        /// 证件类名称
        /// </summary>
        public string CertificateTypeName
        {
            get { return _certificateTypeName; }
            set { _certificateTypeName = value; }
        }
    }
}
