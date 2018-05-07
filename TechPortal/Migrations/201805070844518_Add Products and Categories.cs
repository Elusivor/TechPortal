namespace Techportal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProductsandCategories : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductCategories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Markup = c.Short(nullable: false),
                        Discount = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        UnitPrice = c.Single(nullable: false),
                        StockLevel = c.Int(nullable: false),
                        Category_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ProductCategories", t => t.Category_ID)
                .Index(t => t.Category_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Category_ID", "dbo.ProductCategories");
            DropIndex("dbo.Products", new[] { "Category_ID" });
            DropTable("dbo.Products");
            DropTable("dbo.ProductCategories");
        }
    }
}
