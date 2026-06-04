using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.LiveSports.Infrastructure.Data
{
    internal class BoxingDbContext : DbContext
    {
        //todo entities
        public DbSet<object> Boxers { get; set; }
        public DbSet<object> Matches { get; set; }

        public BoxingDbContext(DbContextOptions<BoxingDbContext> dbContextOptions) : base(dbContextOptions) { }



    }
}
