using System.Collections.Generic;
using TechPortal.Models;

namespace TechPortal.ViewModels
{
    public class ProductFormViewModel
    {
        public IEnumerable<ProductCategory> ProductCategories { get; set; }
        public List<ProductCategory> ProductCategories2 { get; set; }
        public Product Product { get; set; }
        public string ProductName { get; set; }
        public float ProductUnitPrice { get; set; }
        public int ProductStockLevel { get; set; }
        public int ProductDiscountRate { get; set; }
        public ProductCategory ProductCategory { get; set; }
    }
}