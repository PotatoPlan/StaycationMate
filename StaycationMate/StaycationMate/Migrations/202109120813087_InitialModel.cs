namespace StaycationMate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attractions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Location_Name = c.String(),
                        Street_Address = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Postal_Code = c.String(),
                        Latitude = c.Double(nullable: false),
                        Longitude = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Attractions");
        }
    }
}
