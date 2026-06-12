using Pin.LiveSports.Application.Services.Interfaces;
using Pin.LiveSports.Core.Entities;
using Pin.LiveSports.Core.Enums;
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
        private readonly ICrudService<Fighter> _dbFighterCrudService;

        public FighterService(ICrudService<Fighter> dbFighterCrudService)
        {
            _dbFighterCrudService = dbFighterCrudService;
        }

        public async Task AddFighterAsync(Fighter fighter)
        {
            if (string.IsNullOrEmpty(fighter.Firstname)) throw new Exception($"{nameof(fighter.Firstname)} must be provided");
            if (string.IsNullOrEmpty(fighter.Lastname)) throw new Exception($"{nameof(fighter.Lastname)} must be provided");
            await _dbFighterCrudService.AddAsync(fighter);
        }

        public Task DeleteFighterAsync(Fighter fighter)
        {
            throw new NotImplementedException();
        }

        public Task<Fighter[]> GetAllFightersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Fighter> GetFighterByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateFighterAsync(Fighter fighter)
        {
            throw new NotImplementedException();
        }
    }
}
