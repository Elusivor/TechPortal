using System.Collections.Generic;
using TechPortal.Models;

namespace TechPortal.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<CustomerType> CustomerTypes { get; set; }
        public List<CustomerType> CustomerTypes2 { get; set; }
        public Customer Customer { get; set; }
        public string CustomerCompanyName { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerTelephone { get; set; }
        public bool CustomerAllowCredit { get; set; }
    }
}