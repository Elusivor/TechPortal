using System.ComponentModel.DataAnnotations;

namespace TechPortal.Models
{
    public class Customer
    {
        public int ID { get; set; }

        [Required]
        [StringLength(255)]
        public string CompanyName { get; set; }

        public string City { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public bool AllowCredit { get; set; }

        //customertype shit
        public CustomerType CustomerType { get; set; }
        public int CustomerTypeID { get; set; }
    }

  /*public class CustomerType
    {
        public string Description { get; set; }
        public int Discount { get; set; }
        public int GST { get; set; }
    }*/
}