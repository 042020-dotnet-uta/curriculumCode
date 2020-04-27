using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace RPS_Game.Models
{
    public class DbContextClass : DbContext
    {

        public DbContextClass()
        { }

        public DbContextClass(DbContextOptions<DbContextClass> options)
            : base(options)
        { }

        public DbSet<Game>   Games   { get; set; }
        public DbSet<Round>  Rounds  { get; set; }
        public DbSet<Player> Players { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if(!options.IsConfigured)
            options.UseSqlite("Data Source=blogging.db");
        }
    }
}
