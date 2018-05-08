using TechPortal.Models;

namespace TechPortal.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float UnitPrice { get; set; }
        public int StockLevel { get; set; }
        public int DiscountRate { get; set; }
        public ProductCategory Category { get; set; }
    }
}