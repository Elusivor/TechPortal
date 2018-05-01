namespace Techportal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomerTypes : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into CustomerTypes (Description, Discount, ChargeGST) VALUES ('Normal', 0, 1) ");
            Sql("Insert Into CustomerTypes (Description, Discount, ChargeGST) VALUES ('Gold', 5, 1) ");
            Sql("Insert Into CustomerTypes (Description, Discount, ChargeGST) VALUES ('Platinum', 10, 1) ");
            Sql("Insert Into CustomerTypes (Description, Discount, ChargeGST) VALUES ('Government', 3, 0) ");
            Sql("Insert Into CustomerTypes (Description, Discount, ChargeGST) VALUES ('International', 0, 0) ");
            Sql("Insert Into CustomerTypes (Description, Discount, ChargeGST) VALUES ('International Platinum', 8, 0) ");
        }
        
        public override void Down()
        {
            Sql("Truncate Table CustomerTypes");
        }
    }
}
