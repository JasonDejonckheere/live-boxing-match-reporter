using Pin.LiveSports.Application.Services.Interfaces;
using Pin.LiveSports.Core.Entities;
using Pin.LiveSports.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.LiveSports.Application.Services
{
    public class FighterService : IFighterService
    {
        private ICrudService<Fighter> _dbFighterCrudService;

        public FighterService(ICrudService<Fighter> dbFighterCrudService)
        {
            _dbFighterCrudService = dbFighterCrudService;
        }




    }
}
