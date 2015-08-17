namespace ClubNotifier.Migrations
{
    using ClubNotifier.Database;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ClubNotifier.Database.ClubNotifierContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ClubNotifier.Database.ClubNotifierContext";
        }

        protected override void Seed(ClubNotifier.Database.ClubNotifierContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Jobs.AddOrUpdate(
                p => p.Name,
                new Job { Name = "無" }
            );
        }
    }
}
