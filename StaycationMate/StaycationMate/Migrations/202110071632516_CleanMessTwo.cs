namespace StaycationMate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class CleanMessTwo : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.AttractionRatings");
        }

        public override void Down()
        {
        }
    }
}
