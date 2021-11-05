namespace StaycationMate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRatingColumnToAttractions : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Attractions", "Rating", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Attractions", "Rating");
        }
    }
}
