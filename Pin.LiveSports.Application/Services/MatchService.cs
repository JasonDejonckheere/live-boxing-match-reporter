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

        public Task AddMatchAsync(BoxingMatch match)
        {
            throw new NotImplementedException();
        }

        public Task DeleteMatchAsync(BoxingMatch match)
        {
            throw new NotImplementedException();
        }

        public async Task<BoxingMatch[]> GetAllMatchesAsync() => await _dbMatchCrudService.GetAllAsync();

        public async Task<BoxingMatch> GetMatchByIdAsync(Guid id) => await _dbMatchCrudService.GetByIdAsync(id);

        public Task UpdateMatchAsync(BoxingMatch match)
        {
            throw new NotImplementedException();
        }
    }
}
