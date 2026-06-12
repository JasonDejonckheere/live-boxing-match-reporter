using Pin.LiveSports.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.LiveSports.Application.Services.Interfaces
{
    public interface IFighterService
    {
        Task<Fighter[]> GetAllFightersAsync();
        Task<Fighter> GetFighterByIdAsync(Guid id);
        Task AddFighterAsync(Fighter fighter);
        Task UpdateFighterAsync(Fighter fighter);
        Task DeleteFighterAsync(Fighter fighter);
    }
}
