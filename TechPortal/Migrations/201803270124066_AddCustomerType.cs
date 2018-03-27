namespace Techportal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomerType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomerTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Discount = c.Int(nullable: false),
                        ChargeGST = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Customers", "CustomerTypeID", c => c.Int(nullable: false));
            CreateIndex("dbo.Customers", "CustomerTypeID");
            AddForeignKey("dbo.Customers", "CustomerTypeID", "dbo.CustomerTypes", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "CustomerTypeID", "dbo.CustomerTypes");
            DropIndex("dbo.Customers", new[] { "CustomerTypeID" });
            DropColumn("dbo.Customers", "CustomerTypeID");
            DropTable("dbo.CustomerTypes");
        }
    }
}
