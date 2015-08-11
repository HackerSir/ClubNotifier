namespace ClubNotifier.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPersonTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.PersonId);
            
            CreateTable(
                "dbo.Emails",
                c => new
                    {
                        EmailId = c.Int(nullable: false, identity: true),
                        EmailAddress = c.String(nullable: false),
                        Person_PersonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmailId)
                .ForeignKey("dbo.People", t => t.Person_PersonId, cascadeDelete: true)
                .Index(t => t.Person_PersonId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Emails", "Person_PersonId", "dbo.People");
            DropIndex("dbo.Emails", new[] { "Person_PersonId" });
            DropTable("dbo.Emails");
            DropTable("dbo.People");
        }
    }
}
