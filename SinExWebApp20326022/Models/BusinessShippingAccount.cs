using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SinExWebApp20326022.Models
{
    public class BusinessShippingAccount : ShippingAccount
    {
        [Required]
        [Key]
        [StringLength(70)]
        [Display(Name = "Contact Name")]
        public virtual string ContactName { get; set; }

        [Required]
        [StringLength(40)]
        [Display(Name = "Business Name")]
        public virtual string BusinessName { get; set; }

        [StringLength(30)]
        [Display(Name = "Department Name")]
        public virtual string DepartmentName { get; set; }
    }
}