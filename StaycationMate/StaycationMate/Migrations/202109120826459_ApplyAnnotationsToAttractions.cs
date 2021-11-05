namespace StaycationMate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotationsToAttractions : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Attractions", "Location_Name", c => c.String(nullable: false, maxLength: 225));
            AlterColumn("dbo.Attractions", "Street_Address", c => c.String(nullable: false, maxLength: 225));
            AlterColumn("dbo.Attractions", "City", c => c.String(nullable: false, maxLength: 225));
            AlterColumn("dbo.Attractions", "State", c => c.String(nullable: false, maxLength: 225));
            AlterColumn("dbo.Attractions", "Postal_Code", c => c.String(nullable: false, maxLength: 225));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Attractions", "Postal_Code", c => c.String());
            AlterColumn("dbo.Attractions", "State", c => c.String());
            AlterColumn("dbo.Attractions", "City", c => c.String());
            AlterColumn("dbo.Attractions", "Street_Address", c => c.String());
            AlterColumn("dbo.Attractions", "Location_Name", c => c.String());
        }
    }
}
