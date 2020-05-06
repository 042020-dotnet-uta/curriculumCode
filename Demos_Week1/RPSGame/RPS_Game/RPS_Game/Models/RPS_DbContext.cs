using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace RPS_Game.Models
{
    public class RPS_DbContext: DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Round> Rounds { get; set; }
        public DbSet<Player> Players { get; set; }

        public RPS_DbContext() { }

        public RPS_DbContext(DbContextOptions<RPS_DbContext> options) 
            : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlite("Data Source=rpsGame.db");
                //options.UseSqlServer("Server=MARKCMOORE\\SQLEXPRESS\\SQLEXPRESS;Database=rpsgame;");
                //options.UseSqlServer("Data Source=(LocalDb)\\MARKCMOORE");

                
            }
            //Database.EnsureCreated();
        }
    }
}
