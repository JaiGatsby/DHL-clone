using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SinExWebApp20326022.Models
{
    public class PersonalShippingAccount : ShippingAccount
    {
        [Required]
        [Key]
        [Display(Name = "First Name")]
        public virtual string FirstName { get; set; }
        [Required]
        [StringLength(35)]
        [Display(Name = "Last Name")]
        public virtual string LastName { get; set; }
    }
}