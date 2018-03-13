namespace VidlyTutorial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense], [Phone]) VALUES (N'6afbcaec-96e0-46b0-b394-8ee0c69e647c', N'guest1@vidly.com', 0, N'ALIxfD2+mlT3PM5s8fz1liVyA8bpD0ut9Om7neYIvUfGqAaEJEZb3eosNwYThP1LGw==', N'4a8ad61b-476c-4034-a375-ce8f154f8992', NULL, 0, 0, NULL, 1, 0, N'guest1@vidly.com', N'23456', N'0507741064')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense], [Phone]) VALUES (N'90ac5140-826c-4735-9dc0-c8558260b9e5', N'admin1@vidly.com', 0, N'AGxVJc+QGx6QBZJtdyPivx/bZqGqEtMk8EZhdsN+j5rnuqKIX+4Ibf39G+Tbvtj0jA==', N'b452febe-aee2-417b-a18e-b1e7041620e9', NULL, 0, 0, NULL, 1, 0, N'admin1@vidly.com', N'12345', N'0637741064')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense], [Phone]) VALUES (N'fdbb51b9-3eae-4d55-ba17-13457f126f59', N'guest2@vidly.com', 0, N'AI+JEyrZ2pL490gSbrWptmf64InhKgJjTncp+I3P8nUf0727vp+TOBhpbxqBW0C2dA==', N'052c9537-deef-47b3-9ab0-4880cfeee674', NULL, 0, 0, NULL, 1, 0, N'guest2@vidly.com', N'65432', N'0677741064')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ebf39057-4ff7-4b53-ac81-04005125cf9f', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'90ac5140-826c-4735-9dc0-c8558260b9e5', N'ebf39057-4ff7-4b53-ac81-04005125cf9f')

");
        }
        
        public override void Down()
        {
        }
    }
}
