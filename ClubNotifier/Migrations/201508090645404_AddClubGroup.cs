namespace ClubNotifier.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClubGroup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClubGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Clubs", "Group_Id", c => c.Int());
            CreateIndex("dbo.Clubs", "Group_Id");
            AddForeignKey("dbo.Clubs", "Group_Id", "dbo.ClubGroups", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clubs", "Group_Id", "dbo.ClubGroups");
            DropIndex("dbo.Clubs", new[] { "Group_Id" });
            DropColumn("dbo.Clubs", "Group_Id");
            DropTable("dbo.ClubGroups");
        }
    }
}
