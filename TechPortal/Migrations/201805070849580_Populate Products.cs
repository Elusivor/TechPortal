namespace Techportal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class PopulateProducts : DbMigration
    {
        public override void Up()
        {
            //Shampoo
            Sql("Insert into Products(Name, StockLevel, UnitPrice, DiscountRate, Category_ID) VALUES ('Unicorn Shampoo', 999, 999, 15, 1)");
            Sql("Insert into Products(Name, StockLevel, UnitPrice, DiscountRate, Category_ID) VALUES ('Rainbow Shampoo', 456, 658, 0, 1)");
            Sql("Insert into Products(Name, StockLevel, UnitPrice, DiscountRate, Category_ID) VALUES ('Gold shampoo', 50, 898, 10, 1)");

            //Eyewear
            Sql("Insert into Products(Name, StockLevel, UnitPrice, DiscountRate, Category_ID) VALUES ('Sunnies', 4, 98.98, 0, 2)");
            Sql("Insert into Products(Name, StockLevel, UnitPrice, DiscountRate, Category_ID) VALUES ('Snowboarding Goggles', 24, 104.65, 13, 2)");
            Sql("Insert into Products(Name, StockLevel, UnitPrice, DiscountRate, Category_ID) VALUES ('Dive Mask', 34, 47.87, 6, 2)");
            Sql("Insert into Products(Name, StockLevel, UnitPrice, DiscountRate, Category_ID) VALUES ('Snorkel', 721, 4.99, 20, 2)");

            //Puzzles
            Sql("Insert into Products(Name, StockLevel, UnitPrice, DiscountRate, Category_ID) VALUES ('aMAZEing Puzzles', 500, 15, 20, 3)");
            Sql("Insert into Products(Name, StockLevel, UnitPrice, DiscountRate, Category_ID) VALUES ('Wasgij', 50, 35.65, 15, 3)");

            //Pool
            Sql("Insert into Products(Name, StockLevel, UnitPrice, DiscountRate, Category_ID) VALUES ('Fill it Up', 450, 300.23, 5, 4)");
            Sql("Insert into Products(Name, StockLevel, UnitPrice, DiscountRate, Category_ID) VALUES ('Flowing', 45, 674.87, 9, 4)");

        }

        public override void Down()
        {
            Sql("TRUNCATE TABLE Products");
            Sql("DBCC CHECKIDENT(Products, RESEED, 1);");

        }
    }
}