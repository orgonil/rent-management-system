using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Renting_Management_System.Models
{
    class ImageTypeMod
    {
        private string _imageTypeCode;
        /// <summary>
        /// 影像类代码
        /// </summary>
        public string ImageTypeCode
        {
            get { return _imageTypeCode; }
            set { _imageTypeCode = value; }
        }
        private string _imageTypeName;
        /// <summary>
        /// 影像类名称
        /// </summary>
        public string ImageTypeName
        {
            get { return _imageTypeName; }
            set { _imageTypeName = value; }
        }
    }
}
