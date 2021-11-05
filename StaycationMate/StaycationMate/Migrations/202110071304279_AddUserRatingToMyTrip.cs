namespace StaycationMate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserRatingToMyTrip : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MyTrips", "User_Rating", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MyTrips", "User_Rating");
        }
    }
}
