namespace StaycationMate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'887df402-b988-44dc-a953-4f5b98532a6d', N'admin@staycationmate.com', 0, N'APlutZoVIKfyeVrR0RCtToTxoTfN5GFVHBGVwhwm4rg5wnVt6I2vgeJymwkfoWUJJw==', N'0f64dcef-b813-4494-afe3-06312cd267e0', NULL, 0, 0, NULL, 1, 0, N'admin@staycationmate.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd7370212-3fc6-4cb9-a134-0203f568b0a7', N'guest@staycationmate.com', 0, N'AKt0DEnN1fSiV2klwKjeR2QfscExbJpfYj+gMGfx94GLoups5RiSzmvbisBu/JPb6w==', N'316af74e-f77e-40dc-90c2-55cb48453b28', NULL, 0, 0, NULL, 1, 0, N'guest@staycationmate.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'7aa6edc7-f8cf-408d-a3eb-caf1d50e454f', N'CanManageAttractions')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'887df402-b988-44dc-a953-4f5b98532a6d', N'7aa6edc7-f8cf-408d-a3eb-caf1d50e454f')

            ");
        }

        public override void Down()
        {
        }
    }
}
