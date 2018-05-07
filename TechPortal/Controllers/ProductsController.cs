using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Techportal.Models;
using TechPortal.Models;

namespace TechPortal.Controllers
{
    public class ProductsController : Controller
    {
        private ApplicationDbContext _context;

        public ProductsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
            base.Dispose(disposing);
        }
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
            var products = _context.Products.Include(c => c.Category).ToList();
            return View(products);
        }
        public ActionResult Edit(int ID)
        {
            var product = _context.Products.Include(c =>c.Category).SingleOrDefault(c => c.ID == ID);

            if (product == null)
                return HttpNotFound();

            return View(product);
        }
    }
}