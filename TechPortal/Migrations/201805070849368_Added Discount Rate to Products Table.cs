namespace TechPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDiscountRatetoProductsTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "DiscountRate", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "DiscountRate");
        }
    }
}
