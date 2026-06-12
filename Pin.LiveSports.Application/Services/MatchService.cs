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
    public class MatchService : IMatchService
    {
        private readonly ICrudService<BoxingMatch> _dbMatchCrudService;

        public MatchService(ICrudService<BoxingMatch> dbMatchCrudService)
        {
            _dbMatchCrudService = dbMatchCrudService;
        }

        public async Task DeleteMatchAsync(BoxingMatch match)
        {
            if (await GetMatchByIdAsync(match.Id) is null) throw new Exception($"Match deletion failed. Match does not exist");
            await _dbMatchCrudService.DeleteAsync(match);
        }

        public async Task<BoxingMatch[]> GetAllMatchesAsync() => await _dbMatchCrudService.GetAllAsync();

        public async Task<BoxingMatch> GetMatchByIdAsync(Guid id) => await _dbMatchCrudService.GetByIdAsync(id);

        public async Task SaveMatchAsync(BoxingMatch match)
        {
            //todo match validation
            if (match.FighterBlueTeamId == Guid.Empty) throw new Exception($"Match requires a blue team fighter");
            if (match.FighterRedTeamId == Guid.Empty) throw new Exception($"Match requires a red team fighter");

            if (match.Id == Guid.Empty)
            {
                await _dbMatchCrudService.AddAsync(match);
            }
            else
            {
                await _dbMatchCrudService.UpdateAsync(match);
            }
        }
    }
}
