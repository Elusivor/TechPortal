using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Techportal.Models;

namespace Techportal.ViewModels
{
    public class ArbitraryCustomerViewModel
    {
        public Customer customer { get; set; }
        public List<ProductViewModel> products { get; set; }
    }
}