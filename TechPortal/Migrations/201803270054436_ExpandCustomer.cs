namespace TechPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExpandCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Email", c => c.String());
            AddColumn("dbo.Customers", "Telephone", c => c.String());
            AddColumn("dbo.Customers", "AllowCredit", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "AllowCredit");
            DropColumn("dbo.Customers", "Telephone");
            DropColumn("dbo.Customers", "Email");
        }
    }
}
