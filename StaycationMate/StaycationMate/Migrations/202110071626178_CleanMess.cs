namespace StaycationMate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class CleanMess : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AttractionRatings",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Attraction_Id = c.Int(nullable: false),
                    Attraction_Name = c.String(),
                    User_Id = c.String(),
                })
                .PrimaryKey(t => t.Id);
        }

        public override void Down()
        {
            DropTable("dbo.AttractionRatings");

        }
    }
}
