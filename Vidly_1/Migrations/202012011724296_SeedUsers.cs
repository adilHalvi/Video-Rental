namespace Vidly_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1049b74f-0e57-4268-9069-8967dbd62549', N'guest@vidly.com', 0, N'ACPcJgXO8xkihv4x0BDChyGvweoK+U0uC8VzBGxo8vOt0Ek0ARqpsl3exlBDJY2Oxw==', N'e06b153a-c9e7-49e5-b12e-0dde5e9625cf', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ac23634d-bccc-491c-a1f3-15fd036a97a1', N'admin@vidly.com', 0, N'AN2uBZQOSgcaEEGygl8isOEKzC4hLbObjBI+YYqwPUanYQsC92/tvqwGNH+wVk+gIA==', N'854ba728-62cd-4eae-a5f1-cd0a7584f420', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'876eb418-fe93-44eb-b5e7-435fd2b16601', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ac23634d-bccc-491c-a1f3-15fd036a97a1', N'876eb418-fe93-44eb-b5e7-435fd2b16601')

        ");
        }
        
        public override void Down()
        {
        }
    }
}
