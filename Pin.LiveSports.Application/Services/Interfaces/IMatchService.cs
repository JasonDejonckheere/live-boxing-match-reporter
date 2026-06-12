using Pin.LiveSports.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.LiveSports.Application.Services.Interfaces
{
    public interface IMatchService
    {
        Task<BoxingMatch[]> GetAllMatchesAsync();
        Task<BoxingMatch> GetMatchByIdAsync(Guid id);
        Task AddMatchAsync(BoxingMatch match);
        Task UpdateMatchAsync(BoxingMatch match);
        Task DeleteMatchAsync(BoxingMatch match);
    }
}
