namespace LibraryProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserBooksUpdate : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.UserBooks");
            DropColumn("dbo.UserBooks", "UserId");
            AddColumn("dbo.UserBooks", "Id", c => c.Int(nullable: false, identity: true));
            //AlterColumn("dbo.UserBooks", "UserId", c => c.Int(nullable: false, identity: false));
            AddColumn("dbo.UserBooks", "UserId", c => c.Int(nullable: false, identity: false));
            AddPrimaryKey("dbo.UserBooks", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.UserBooks");
            AlterColumn("dbo.UserBooks", "UserId", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.UserBooks", "Id");
            AddPrimaryKey("dbo.UserBooks", "UserId");
        }
    }
}
