namespace Techportal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotations : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CustomerTypes", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Customers", "CompanyName", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.CustomerTypes", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CustomerTypes", "Description", c => c.String());
            AlterColumn("dbo.Customers", "CompanyName", c => c.String());
            DropColumn("dbo.CustomerTypes", "Name");
        }
    }
}
