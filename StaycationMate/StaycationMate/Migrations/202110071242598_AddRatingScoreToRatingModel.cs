namespace StaycationMate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRatingScoreToRatingModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AttractionRatings", "Rating_Score", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AttractionRatings", "Rating_Score");
        }
    }
}
