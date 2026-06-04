using Microsoft.EntityFrameworkCore;
using Pin.LiveSports.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pin.LiveSports.Infrastructure.Data
{
    public class BoxingDbContext : DbContext
    {
        //todo entities
        public DbSet<Fighter> Fighters { get; set; }
        public DbSet<BoxingMatch> BoxingMatches { get; set; }

        public BoxingDbContext(DbContextOptions<BoxingDbContext> dbContextOptions) : base(dbContextOptions) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BoxingMatch>()
                .HasMany(m => m.Fighters)
                .WithMany(f => f.AssignedMatches);

            modelBuilder.Entity<Fighter>()
                .HasMany(f => f.AssignedMatches)
                .WithMany(m => m.Fighters);

            DataSeeder.Seed(modelBuilder);
        }



    }
}
