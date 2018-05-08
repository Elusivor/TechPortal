using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TechPortal.Models
{
    public class CustomerType
    {
        public int ID { get; set; }

        //Fixes Null Error
        [Required]
        [StringLength(255)]
        public String Name { get; set; }

        public int Discount { get; set; }
        public bool ChargeGST { get; set; }
    }
}