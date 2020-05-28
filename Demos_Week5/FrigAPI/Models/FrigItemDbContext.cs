using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FrigAPI.Models
{
    public class FrigItemDbContext : DbContext
    {
        public FrigItemDbContext(DbContextOptions<FrigItemDbContext> options) : base(options)
        {

        }

        public DbSet<FrigFood> FrigFoods { get; set; }
    }
}
