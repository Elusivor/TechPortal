using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechPortal.Models;
using TechPortal.ViewModels;

namespace TechPortal.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Random()
        {
            var randomcustomer = new Customer()
            {
                ID = 0,
                CompanyName = "TechBest"
            };

            var randomList = new List<Product>
            {
                new Product {ID=1, Name="Product A"},
                new Product {ID=1, Name="Product A"},
                new Product {ID=1, Name="Product A"}
            };

            var viewmodel = new ArbitraryCustomerViewModel
            {
                customer = randomcustomer,
                products = randomList
            };
            return View(viewmodel);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            var customers = new List<Customer>
            {
                new Customer{ID=1, CompanyName="BlackBox Studios", City="Hamilton"},
                new Customer{ID=2, CompanyName="Focus Studios", City="Auckland"},
                new Customer{ID=3, CompanyName="Burst the Game is better than Desolation", City="Wellington"}
            };
            return customers;
        }
        public ActionResult Index()
        {
            return View(GetCustomers());
        }

        public ActionResult Param(int ID)
        {
            return Content(ID.ToString());
        }
        public ActionResult Optional (int? rowcount, string sortby)
        {
            if (!rowcount.HasValue)
                rowcount = 1;
            if (String.IsNullOrWhiteSpace(sortby))
                sortby = "No SortBy criteria FEGGET";
            return Content($"Optional Test. {Environment.NewLine} RowCount: " +rowcount.ToString()+"\r\n SortBy: " +sortby);
        }
        public ActionResult ByCountryAndStatus(string Country, string Status)
        {
            return Content($"Country: {Country}, Status: {Status}");
        }
        public ActionResult YMD(int Year, int Month, int Day)
        {
            if (Month > 12)
                return Content("Please enter a month under 12");
            if (Day > 32)
                return Content("Please enter a day under 32");
            return Content($"Year {Year}, Month {Month}, Day {Day}");
        }

        public ActionResult Edit (int ID)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.ID == ID);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }
    }
}
