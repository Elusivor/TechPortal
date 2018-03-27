using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechPortal.Models;

namespace TechPortal.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Random()
        {
            var randomcustomer = new Product()
            {
                ID = 9,
                Name = "Product XGFT"
            };

            return View(randomcustomer);
        }
        private IEnumerable<Product> GetProducts()
        {
            var products = new List<Product>
            {
                new Product{ID=1, Name="Aftershock"},
                new Product{ID=2, Name="Desolation"},
                new Product{ID=3, Name="Burst the Game"}
            };
            return products;
        }
        public ActionResult Index()
        {
            return View(GetProducts());
        }
        public ActionResult Edit(int ID)
        {
            var products = GetProducts().SingleOrDefault(c => c.ID == ID);

            if (products == null)
                return HttpNotFound();

            return View(products);
        }
    }
}