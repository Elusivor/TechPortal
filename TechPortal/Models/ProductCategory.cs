namespace Techportal.Models
{
    public class ProductCategory
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public short Markup { get; set; }
        public short Discount { get; set; }
    }
}