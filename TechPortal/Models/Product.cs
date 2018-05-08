using System.ComponentModel.DataAnnotations;

namespace TechPortal.Models
{
    public class Product
    {
        public int ID { get; set; }
        [Display(Name = "Product Name")]
        public string Name { get; set; }
        [Display(Name= "Product Unit Price")]
        public float UnitPrice { get; set; }
        [Display(Name = "Product Stock Level")]
        public int StockLevel { get; set; }
        [Display(Name= "Product Discount Rate")]
        public int DiscountRate { get; set; }
        [Display(Name="Product Category")]
        public ProductCategory Category { get; set; }
    }
}