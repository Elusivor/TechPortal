namespace Techportal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateProductCategories : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into ProductCategories(Name, Description, Markup, Discount) VALUES ('Shampoo','This shampoo will make your feel like your hair has gone through a rainbow and you have come out with a pot full of gold', 5, 20)");
            Sql("Insert into ProductCategories(Name, Description, Markup, Discount) VALUES ('Eyewear', 'Check out these new sunnies and you will be protected from the laser rays forever', 0, 0)");
            Sql("Insert into ProductCategories(Name, Description, Markup, Discount) VALUES ('Puzzles', 'The new puzzles are here and are ready to be lost inside of', 50, 25)");
            Sql("Insert into ProductCategories(Name, Description, Markup, Discount) VALUES ('Pool Accessories', 'Fill it Up will fill your life up with all the water you could possibly need in your backyard', 100, 150)");

        }

        public override void Down()
        {
            Sql("Truncate Table ProductCategories");
            Sql("DBCC CHECKIDENT(ProductCategories, RESEED, 0);");
        }
    }
}
