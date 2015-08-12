namespace ClubNotifier.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddJobTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Jobs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.People", "Job_Id", c => c.Int());
            CreateIndex("dbo.People", "Job_Id");
            AddForeignKey("dbo.People", "Job_Id", "dbo.Jobs", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "Job_Id", "dbo.Jobs");
            DropIndex("dbo.People", new[] { "Job_Id" });
            DropColumn("dbo.People", "Job_Id");
            DropTable("dbo.Jobs");
        }
    }
}
