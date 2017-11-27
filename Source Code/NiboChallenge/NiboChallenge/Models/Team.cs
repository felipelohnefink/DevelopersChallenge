using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace NiboChallenge.Models
{
    public class Team
    {
        public int ID { get; set; }
        public string TeamName { get; set; }
        public decimal Points { get; set; }
    }

    public class TeamDBContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }
    }
}