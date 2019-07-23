using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources.team;

namespace FootballCntext
{
    public class Class1 : DbContext
    {
        public DbSet <Player> Players { get; set; }
        public DbSet<team> Team
    }
}
