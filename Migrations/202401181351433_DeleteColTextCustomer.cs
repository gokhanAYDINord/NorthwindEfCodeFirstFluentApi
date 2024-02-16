namespace NorthwindEfCodeFirstFluentApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteColTextCustomer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(nullable: false, maxLength: 40),
                        ContactName = c.String(nullable: false, maxLength: 30),
                        ContactTitle = c.String(nullable: false, maxLength: 30),
                        Address = c.String(nullable: false, maxLength: 30),
                        City = c.String(nullable: false, maxLength: 15),
                        Region = c.String(nullable: false, maxLength: 15),
                        PostalCode = c.String(nullable: false, maxLength: 15),
                        Country = c.String(nullable: false, maxLength: 15),
                        Phone = c.String(nullable: false, maxLength: 15),
                        Fax = c.String(nullable: false, maxLength: 15),
                        Sex = c.String(nullable: false, maxLength: 15),
                    })
                .PrimaryKey(t => t.CustomerID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        CustomerID = c.Int(nullable: false),
                        ShipCity = c.String(),
                        ShipCountry = c.String(),
                        OrderDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.Patient",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 40),
                        Surname = c.String(nullable: false, maxLength: 30),
                        Birth = c.DateTime(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        Adres = c.String(maxLength: 30),
                        Adres2 = c.String(),
                        Adres3 = c.String(maxLength: 30),
                        Adres4 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 40),
                        Surname = c.String(nullable: false, maxLength: 30),
                        Birth = c.DateTime(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        Adres = c.String(maxLength: 30),
                        Adres2 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "CustomerID", "dbo.Customers");
            DropIndex("dbo.Orders", new[] { "CustomerID" });
            DropTable("dbo.User");
            DropTable("dbo.Patient");
            DropTable("dbo.Orders");
            DropTable("dbo.Customers");
        }
    }
}
