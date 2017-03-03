using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SinExWebApp20326022.Models
{
    [Table("ShippingAccount")]
    public abstract class ShippingAccount
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        //[Key]
        public virtual int ShippingAccountId { get; set; }

        //[Required]
        public virtual string Building { get; set; }
        [Required]
        public virtual string Street { get; set; }
        [Required]
        public virtual string City { get; set; }
        [Required]
        public virtual string Province { get; set; }
        [RegularExpression(@"^[0-9]*$")]
        [Display(Name = "Postal Code")]
        public virtual string PostalCode { get; set; }

        [Required]
        [StringLength(14,MinimumLength =8)]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Phone number must be numeric.")]
        [Display(Name = "Phonenumber")]
        public virtual string PhoneNumber { get; set; }

        [Required]
        [StringLength(30)]
        [RegularExpression(@".+\@.+\..+", ErrorMessage = "Please enter a valid email address.")]
        [Display(Name = "Email")]
        public virtual string EmailAddress { get; set; }

        [Required]
        [Display(Name = "Type")]
        public virtual string CreditCardType { get; set; }
        [Required]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "The field Number must be a number.")]
        [Display(Name = "Number")]
        public virtual string CreditCardNumber { get; set; }
        [Required]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "The field Security Number must be a number.")]
        [Display(Name = "Security Number")]
        public virtual string CreditCardSecurityNumber { get; set; }
        [Required]
        [Display(Name = "Cardholder Name")]
        public virtual string CreditCardCardholderName { get; set; }
        [Required]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "The field Expiry Month must be a number.")]
        [Display(Name = "Expiry Month")]
        public virtual string CreditCardExpiryMonth { get; set; }
        [Required]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "The field Expiry Year must be a number.")]
        [Display(Name = "Expiry Year")]
        public virtual string CreditCardExpiryYear { get; set; }

    }
}