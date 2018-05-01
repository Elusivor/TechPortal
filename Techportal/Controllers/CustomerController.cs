using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Techportal.Models;
using Techportal.ViewModels;

namespace Techportal.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult random()
        {
            var randomcustomer = new Customer()
            {
                ID = 0,
                CompanyName = "TechBest"
            };
       
            var randomList = new List<Product>
            {
                new Product{ ID = 1, Name = "Product A"},
                new Product{ ID = 2, Name = "Product B"},
                new Product{ ID = 3, Name = "Product C"},
                new Product{ ID = 4, Name = "Product D"},
            };

            var viewmodel = new ArbitraryCustomerViewModel
            {
                customer = randomcustomer,
                products = randomList
            };
            return View(viewmodel);
        }

        private IEnumerable<Customer> GetCustomer()
        {
            var customers = new List<Customer>
            {
                new Customer{ ID = 1, CompanyName = "Company A", City = "City A"},
                new Customer{ ID = 2, CompanyName = "Company B", City = "City B"},
                new Customer{ ID = 3, CompanyName = "Company C", City = "City C"},
                new Customer{ ID = 4, CompanyName = "Company D", City = "City D"},
            };

            return customers;
        }

        public ActionResult Edit(int ID)
        {
            var customer = GetCustomer().SingleOrDefault(c => c.ID == ID);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        public ActionResult Index()
        {
            var customers = _context.Customers.ToList();
            return View(GetCustomer());
        }

        public ActionResult Param(int ID)
        {
            //Return If or Else If.
            if (ID == 1)
            {
                return Content("Number 1!");
            }
            else if (ID == 420)
            {
                return Content("What a funny number");
            }
            return Content("Try 1 or 0");
        }

        public ActionResult Optional(int? rowcount, string sortby)
        {
            if (!rowcount.HasValue)
                rowcount = 1;
            if (String.IsNullOrWhiteSpace(sortby))
                sortby = "Name";

            return Content("Optional test. RowCount: " + rowcount.ToString() + ", SortBy: " + sortby);
        }

        public ActionResult ByCountryAndStatus(string Country, string Status)
        {
            return Content($"{Country} | {Status}");
        }

        public ActionResult ByRandomLabRoute(int Year, int Month, int Day)
        {
            return Content($"{Year} | {Month} | {Day}");
        }

        private ApplicationDbContext _context;

        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
    }
}