using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace ClubNotifier.Database {
    class ClubNotifierContext : DbContext 
    {
        public DbSet<Club> Clubs { get; set; }
        public DbSet<ClubGroup> ClubGroup { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Job> Jobs { get; set; }
    }
}
