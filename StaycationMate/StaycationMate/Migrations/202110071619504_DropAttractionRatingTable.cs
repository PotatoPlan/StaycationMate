namespace StaycationMate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class DropAttractionRatingTable : DbMigration
    {
        public override void Up()
        {
            DropTable("AttractionRatings");
        }

        public override void Down()
        {
        }
    }
}
