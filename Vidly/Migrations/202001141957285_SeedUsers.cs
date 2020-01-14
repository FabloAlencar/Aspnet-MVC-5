namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6b016f6d-5249-4d38-b6c6-01a49e5554ed', N'guest@vidly.com', 0, N'ANGlKN6ZRkGCAAuyCY2DfJHvzmcOkU6EkMnCjB/NtMKUvVGyfV0gQ1jB6di0RMbmFg==', N'522d11a9-98d6-4d7f-bfa7-512503bf5123', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com');

INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b0df59e7-07bb-4215-91cd-92483d116c80', N'admin@vidly.com', 0, N'ALmZVPKtX9c4zB1PuJ97X0O0F9Z4ClvygzRu2aYIT1sYZ8wCGUv/WVpJsPfx4KboMw==', N'58d57307-0c5b-492d-a278-dc31612ddec8', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com');

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'be4dff87-8da6-4aa3-a9df-ccf5240fd77c', N'CanManageMovies');

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b0df59e7-07bb-4215-91cd-92483d116c80', N'be4dff87-8da6-4aa3-a9df-ccf5240fd77c');

");
        }

        public override void Down()
        {
        }
    }
}