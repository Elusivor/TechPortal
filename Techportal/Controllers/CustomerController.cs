using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using TechPortal.Models;
using TechPortal.ViewModels;

namespace TechPortal.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Customers
        public ActionResult Random()
        {
            var randomcustomer = new Customer()
            {
                ID = 0,
                CompanyName = "TechBest"
            };

            var randomList = new List<ProductViewModel>
            {
                new ProductViewModel {ID=1, Name="Product A"},
                new ProductViewModel {ID=1, Name="Product A"},
                new ProductViewModel {ID=1, Name="Product A"}
            };

            var viewmodel = new ArbitraryCustomerViewModel
            {
                customer = randomcustomer,
                products = randomList
            };
            return View(viewmodel);
        }

        public ActionResult Edit(int ID)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.ID == ID);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c => c.CustomerType).ToList();
            return View(customers);
        }

        public ActionResult New()
        {
            var viewModel = new NewCustomerViewModel()
            {
                CustomerTypes = _context.CustomerTypes.ToList()
            };
            return View(viewModel);
        }

        public ActionResult Param(int ID)
        {
            return Content(ID.ToString());
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
        public ActionResult YMD(int Year, int Month, int Day)
        {
            if (Month > 12)
                return Content("Please enter a month under 12");
            if (Day > 32)
                return Content("Please enter a day under 32");
            return Content($"Year {Year}, Month {Month}, Day {Day}");
        }

        //public ActionResult Edit(int ID)
        //{
        //    var customer = GetCustomers().SingleOrDefault(c => c.ID == ID);

        //    if (customer == null)
        //        return HttpNotFound();
        //    return View(customer);
        //}
    }   
}