﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SinExWebApp20326022.Models
{
    [Table("Currency")]
    public class Currency
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public virtual string CurrencyCode { get; set; }
        public virtual decimal ExchangeRate { get; set; }

        public virtual ICollection<Destination> Destinations { get; set; }
    }
}