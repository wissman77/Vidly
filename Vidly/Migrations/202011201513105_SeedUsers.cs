namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0d936cfd-37f3-4222-b4e7-0d358208734a', N'guest@vidly.com', 0, N'AKYYqP+KAlFohn7XZ/ci2d7HMC25hmYQJmJHklgmgH9sDj/F/12v0YoElQCnzbhAxA==', N'dc544d4e-74ed-4bc9-9242-71f6131f6a07', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd39a082d-63ab-4f34-8d70-7757a992ab99', N'admin@vidly.com', 0, N'ABYxgPEF5pNift6yAICfJEykbjWxLIXGEQYrEyl+wSkZmiCP16oFDcHfsbKLvS0WlA==', N'8723ef6d-000d-4d43-9a37-0b83a683ef6c', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'2318ba12-e414-4a25-b28b-d300440edb55', N'CanManageMovies')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd39a082d-63ab-4f34-8d70-7757a992ab99', N'2318ba12-e414-4a25-b28b-d300440edb55')

            ");
        }
        
        public override void Down()
        {
        }
    }
}
