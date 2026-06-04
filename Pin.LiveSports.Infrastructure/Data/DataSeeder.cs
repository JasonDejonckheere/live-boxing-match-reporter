using Microsoft.EntityFrameworkCore;
using Pin.LiveSports.Core.Entities;
using Pin.LiveSports.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.LiveSports.Infrastructure.Data
{


    public static class DataSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var fighters = new[]{
                new Fighter{ Id = Guid.NewGuid(), Firstname = "John", Lastname = "Wick", WeightClass = WeightType.Lightweight},
                new Fighter{ Id = Guid.NewGuid(), Firstname = "Steven", Lastname = "Hawk", WeightClass = WeightType.Lightweight},

                new Fighter{ Id = Guid.NewGuid(), Firstname = "Bert", Lastname = "Dert", WeightClass = WeightType.Middleweight},
                new Fighter{ Id = Guid.NewGuid(), Firstname = "Dirk", Lastname = "Hirk", WeightClass = WeightType.Middleweight},

                new Fighter{ Id = Guid.NewGuid(), Firstname = "Hol", Lastname = "De Bol", WeightClass = WeightType.Heavyweight},
                new Fighter{ Id = Guid.NewGuid(), Firstname = "Hank", Lastname = "De Tank", WeightClass = WeightType.Heavyweight},
            };

            var matches = new[]
            {
                new BoxingMatch{ Id = Guid.NewGuid(), FighterBlueTeamId = fighters[0].Id, FighterRedTeamId = fighters[1].Id
                },
                new BoxingMatch{ Id = Guid.NewGuid(), FighterBlueTeamId = fighters[2].Id, FighterRedTeamId = fighters[3].Id
                },
                new BoxingMatch{ Id = Guid.NewGuid(), FighterBlueTeamId = fighters[4].Id, FighterRedTeamId = fighters[5].Id
                },
            };

            modelBuilder.Entity<Fighter>().HasData(fighters);
            modelBuilder.Entity<BoxingMatch>().HasData(matches);

        }

    }
}
