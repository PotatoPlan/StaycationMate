namespace StaycationMate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedAttractionsRating : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Attractions SET Rating = 0");
        }

        public override void Down()
        {
        }
    }
}
