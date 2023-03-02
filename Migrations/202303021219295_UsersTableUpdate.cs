namespace LibraryProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UsersTableUpdate : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "Confirm");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Confirm", c => c.String(nullable: false));
        }
    }
}
