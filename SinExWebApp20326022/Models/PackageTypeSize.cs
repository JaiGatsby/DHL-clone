using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SinExWebApp20326022.Models
{
    public class PackageTypeSize
    {
        public virtual PackageType PackageType { get; set; }
        public virtual int PackageTypeSizeID { get; set; }
        public int MyProperty { get; set; }
    }
}