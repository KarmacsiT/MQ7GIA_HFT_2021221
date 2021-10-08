﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQ7GIA_HFT_2021221_Models
{
    [Table("Contracts")]
    public class Contracts
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContractID { get; set; }

        public string ContractType { get; set; }

        public DateTime ContractDate { get; set; }

        public DateTime? ContractExpireDate { get; set; }


        [NotMapped]
        public virtual Customers Customer { get; set; }
        [ForeignKey(nameof(Customer))]
        public int CustomerID { get; set; }


        [NotMapped]
        public virtual Cars Car { get; set; }
        [ForeignKey(nameof(Car))]
        public int CarID { get; set; }
    }
}
