namespace LibraryProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Author = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        SeeUserDetails = c.Boolean(nullable: false),
                        SeeYourBooks = c.Boolean(nullable: false),
                        BorrowBook = c.Boolean(nullable: false),
                        SeeAllBooks = c.Boolean(nullable: false),
                        AddBook = c.Boolean(nullable: false),
                        RemoveBook = c.Boolean(nullable: false),
                        SeeAllUsers = c.Boolean(nullable: false),
                        AddUser = c.Boolean(nullable: false),
                        RemoveUser = c.Boolean(nullable: false),
                        SeeAllRoles = c.Boolean(nullable: false),
                        AddRole = c.Boolean(nullable: false),
                        RemoveRole = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Confirm = c.String(nullable: false),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserBooks",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        BookId = c.Int(nullable: false),
                        BorrowStart = c.DateTime(nullable: false),
                        BorrowEnd = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserBooks");
            DropTable("dbo.Users");
            DropTable("dbo.Roles");
            DropTable("dbo.Books");
        }
    }
}
