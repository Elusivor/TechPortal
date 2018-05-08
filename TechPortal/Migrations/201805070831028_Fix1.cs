namespace TechPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fix1 : DbMigration
    {
        public override void Up()
        {
            Sql("Delete from Customers where 1 = 1");
            Sql("Delete from CustomerTypes where 1 = 1");
            Sql("DBCC CHECKIDENT(CustomerTypes, RESEED, 0);");
            Sql("Insert into CustomerTypes(Name, Discount, ChargeGST) VALUES ('Normal', 0, 1) ");
            Sql("Insert into CustomerTypes(Name, Discount, ChargeGST) VALUES ('Gold', 5, 1 )");
            Sql("Insert into CustomerTypes(Name, Discount, ChargeGST) VALUES ('Platinum', 10, 1 )");
            Sql("Insert into CustomerTypes(Name, Discount, ChargeGST) VALUES ('Government', 3, 0 )");
            Sql("Insert into CustomerTypes(Name, Discount, ChargeGST) VALUES ('International', 0, 0)");
            Sql("Insert into CustomerTypes(Name, Discount, ChargeGST) VALUES ('International Platinum', 8, 0) ");

        }
        public override void Down()
        {
            Sql("Delete * from CustomerTypes ");
            Sql("DBCC CHECKIDENT(CustomerTypes, RESEED, 0);");
        }
    }
}
