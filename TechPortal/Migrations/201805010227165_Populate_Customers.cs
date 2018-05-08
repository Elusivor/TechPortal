namespace TechPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using TechPortal.Models;

    public partial class Populate_Customers : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers(CompanyName, City, Email,Telephone,AllowCredit, CustomerTypeID) VALUES('BlackBox-Studios','Auckland','help@blackboxstudios.net','0211234567','false',1)");
            Sql("INSERT INTO Customers(CompanyName, City, Email,Telephone,AllowCredit, CustomerTypeID) VALUES('Bananas.net','Auckland','help@bananas.net','02112378547','true',3)");
            Sql("INSERT INTO Customers(CompanyName, City, Email,Telephone,AllowCredit, CustomerTypeID) VALUES('Kid Flash','Auckland','KidFlash@TeamFlash.com','02112349','false',4)");
        }

        public override void Down()
        {
            Sql("Truncate table Customers");
            Sql("DBCC CHECKIDENT(Customers, RESEED, 1);");
        }
    }
}
