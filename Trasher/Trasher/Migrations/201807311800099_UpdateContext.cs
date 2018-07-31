namespace Trasher.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateContext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        LastName = c.String(),
                        FirstMidName = c.String(),
                        Address = c.String(),
                        Zip = c.Int(nullable: false),
                        PickupDay = c.String(),
                        IsPickedUp = c.Boolean(nullable: false),
                        AmountDue = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerID);
            
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        LastName = c.String(),
                        FirstMidName = c.String(),
                        Zip = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeID);
            
            CreateTable(
                "dbo.PickupDay",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        dayName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PickupDay");
            DropTable("dbo.Employee");
            DropTable("dbo.Customer");
        }
    }
}
