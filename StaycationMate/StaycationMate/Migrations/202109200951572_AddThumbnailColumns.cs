namespace StaycationMate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddThumbnailColumns : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Attractions", "Thumbnail", c => c.String());
            AddColumn("dbo.Attractions", "Alternative_Text", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Attractions", "Alternative_Text");
            DropColumn("dbo.Attractions", "Thumbnail");
        }
    }
}
