using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SinExWebApp20326022.ViewModels
{
        public class ShipmentsSearchViewModel
    {
        //public virtual string startDate { get; set; }
        //public virtual DateTime endDate { get; set; }



        public virtual int SDay { get; set; }
        public virtual int SMonth { get; set; }

        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Year must be numeric.")]
        public virtual int SYear { get; set; }

        public virtual int EDay { get; set; }
        public virtual int EMonth { get; set; }

        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Year must be numeric.")]
        public virtual int EYear { get; set; }

        public virtual int ShippingAccountId { get; set; }
        public virtual List<SelectListItem> ShippingAccounts { get; set; }
    }
}