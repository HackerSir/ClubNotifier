namespace ClubNotifier.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeClubKey : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Clubs");
            AddPrimaryKey("dbo.Clubs", "ClubCode");
            DropColumn("dbo.Clubs", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clubs", "Id", c => c.Int(nullable: false));
            DropPrimaryKey("dbo.Clubs");
            AddPrimaryKey("dbo.Clubs", new[] { "Id", "ClubCode" });
        }
    }
}
