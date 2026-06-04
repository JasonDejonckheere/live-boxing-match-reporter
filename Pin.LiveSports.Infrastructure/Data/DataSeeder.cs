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
                new BoxingMatch{ Id = Guid.NewGuid(), 
                    //FighterOneId = fighters[0].Id, FighterTwoId = fighters[1].Id 
                },
                new BoxingMatch{ Id = Guid.NewGuid(),
                    //FighterOneId = fighters[2].Id, FighterTwoId = fighters[3].Id 
                },
                new BoxingMatch{ Id = Guid.NewGuid(), 
                    //FighterOneId = fighters[4].Id, FighterTwoId = fighters[5].Id 
                },
            };

            //i know this is not the cleanest way to do this but its fastest way i know + for scope of this exam i'll leave it like this
            var boxingMatchFighters = new[]
            {
                new { FightersId = fighters[0].Id, AssignedMatchesId = matches[0].Id },
                new { FightersId = fighters[1].Id, AssignedMatchesId = matches[0].Id },
                new { FightersId = fighters[2].Id, AssignedMatchesId = matches[1].Id },
                new { FightersId = fighters[3].Id, AssignedMatchesId = matches[1].Id },
                new { FightersId = fighters[4].Id, AssignedMatchesId = matches[2].Id },
                new { FightersId = fighters[5].Id, AssignedMatchesId = matches[2].Id },
            };

            modelBuilder.Entity<Fighter>().HasData(fighters);
            modelBuilder.Entity<BoxingMatch>().HasData(matches);
            modelBuilder.Entity(nameof(BoxingMatch) + nameof(Fighter)).HasData(boxingMatchFighters);

        }

    }
}
