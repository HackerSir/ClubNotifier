using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubNotifier.Database {
    class ClubNotifierContext : DbContext 
    {
        public DbSet<Club> Clubs { get; set; } 
    }
}
