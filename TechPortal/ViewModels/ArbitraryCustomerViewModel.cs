using System.Collections.Generic;
using TechPortal.Models;

namespace TechPortal.ViewModels
{
    public class ArbitraryCustomerViewModel
    {
        public Customer customer { get; set; }
        public List<ProductViewModel> products { get; set; }
    }
}