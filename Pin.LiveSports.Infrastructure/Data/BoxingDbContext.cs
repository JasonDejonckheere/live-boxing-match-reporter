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
                .HasOne(bm => bm.FighterBlueTeam)
                .WithMany(f => f.AssignedMatches)
                .HasForeignKey(bm => bm.FighterBlueTeamId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<BoxingMatch>()
                .HasOne(bm => bm.FighterRedTeam)
                .WithMany(f => f.AssignedMatches)
                .HasForeignKey(bm => bm.FighterRedTeamId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Fighter>()
                .HasMany(f => f.AssignedMatches);

            DataSeeder.Seed(modelBuilder);
        }



    }
}
