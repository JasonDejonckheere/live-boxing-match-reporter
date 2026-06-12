using Pin.LiveSports.Application.Services.Interfaces;
using Pin.LiveSports.Core.Entities;
using Pin.LiveSports.Core.Enums;
using Pin.LiveSports.Core.Interfaces;
using Pin.LiveSports.Infrastructure.Services;
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
        private readonly ICrudService<BoxingMatch> _dbMatchCrudService;


        public FighterService(ICrudService<Fighter> dbFighterCrudService, ICrudService<BoxingMatch> dbMatchCrudService)
        {
            _dbFighterCrudService = dbFighterCrudService;
            _dbMatchCrudService = dbMatchCrudService;
        }

        public async Task SaveFighterAsync(Fighter fighter)
        {
            if (string.IsNullOrEmpty(fighter.Firstname)) throw new Exception($"{nameof(fighter.Firstname)} must be provided");
            if (string.IsNullOrEmpty(fighter.Lastname)) throw new Exception($"{nameof(fighter.Lastname)} must be provided");
            if (fighter.Id == Guid.Empty)
            {
                await _dbFighterCrudService.AddAsync(fighter);
            }
            else
            {
                await _dbFighterCrudService.AddAsync(fighter);
            }
            await _dbFighterCrudService.AddAsync(fighter);
        }

        public async Task DeleteFighterAsync(Fighter fighter)
        {
            var matchesArray = await _dbMatchCrudService.GetAllAsync();
            List<BoxingMatch> allMatches = matchesArray.ToList();
            if (allMatches.Any(m => m.FighterBlueTeam == fighter) || allMatches.Any(m => m.FighterRedTeam == fighter))
            {
                throw new Exception($"Can't delete fighter {fighter.Firstname} {fighter.Lastname} ({fighter.WeightClass}) with id {fighter.Id}. Fighter in a match.");
            }
            await _dbFighterCrudService.DeleteAsync(fighter);
        }

        public async Task<Fighter[]> GetAllFightersAsync() => await _dbFighterCrudService.GetAllAsync();

        public async Task<Fighter> GetFighterByIdAsync(Guid id) => await _dbFighterCrudService.GetByIdAsync(id);

        public async Task UpdateFighterAsync(Fighter fighter)
        {
            var existing = await GetFighterByIdAsync(fighter.Id);
            if (existing is null) throw new Exception($"Updating failed. Fighter does not exist.");
            if (string.IsNullOrEmpty(fighter.Firstname)) throw new Exception($"{nameof(fighter.Firstname)} must be provided");
            if (string.IsNullOrEmpty(fighter.Lastname)) throw new Exception($"{nameof(fighter.Lastname)} must be provided");
        }
    }
}
