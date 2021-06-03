namespace WPF.DAL.Impl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FlightEs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Time = c.DateTime(nullable: false),
                        LastBuyTime = c.DateTime(nullable: false),
                        DelayTime = c.Time(nullable: false, precision: 7),
                        PlaneID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PlaneEs", t => t.PlaneID)
                .Index(t => t.PlaneID);
            
            CreateTable(
                "dbo.PlaneEs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PassengerEs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TicketEs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FlightID = c.Int(),
                        PassengerID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FlightEs", t => t.FlightID)
                .ForeignKey("dbo.PassengerEs", t => t.PassengerID)
                .Index(t => t.FlightID)
                .Index(t => t.PassengerID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TicketEs", "PassengerID", "dbo.PassengerEs");
            DropForeignKey("dbo.TicketEs", "FlightID", "dbo.FlightEs");
            DropForeignKey("dbo.FlightEs", "PlaneID", "dbo.PlaneEs");
            DropIndex("dbo.TicketEs", new[] { "PassengerID" });
            DropIndex("dbo.TicketEs", new[] { "FlightID" });
            DropIndex("dbo.FlightEs", new[] { "PlaneID" });
            DropTable("dbo.TicketEs");
            DropTable("dbo.PassengerEs");
            DropTable("dbo.PlaneEs");
            DropTable("dbo.FlightEs");
        }
    }
}
