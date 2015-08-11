namespace ClubNotifier.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPeopleTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        EmailAddress = c.String(),
                        Club_ClubCode = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.PersonId)
                .ForeignKey("dbo.Clubs", t => t.Club_ClubCode)
                .Index(t => t.Club_ClubCode);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "Club_ClubCode", "dbo.Clubs");
            DropIndex("dbo.People", new[] { "Club_ClubCode" });
            DropTable("dbo.People");
        }
    }
}
