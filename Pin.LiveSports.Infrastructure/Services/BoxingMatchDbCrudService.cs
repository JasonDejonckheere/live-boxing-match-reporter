using Pin.LiveSports.Core.Entities;
using Pin.LiveSports.Infrastructure.Data;
using Pin.LiveSports.Core.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Pin.LiveSports.Infrastructure.Services
{
    public class BoxingMatchDbCrudService : ICrudService<BoxingMatch>
    {
        private readonly BoxingDbContext _db;

        public BoxingMatchDbCrudService(BoxingDbContext db)
        {
            _db = db;
        }

        public async Task AddAsync(BoxingMatch entity)
        {
            await _db.BoxingMatches.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(BoxingMatch entity)
        {
            _db.BoxingMatches.Remove(entity);
            await _db.SaveChangesAsync();
        }

        public async Task<BoxingMatch[]> GetAllAsync()
        {
            return await _db.BoxingMatches
                .OrderBy(bm => bm.IsFinished)
                .Include(bm => bm.WinningFighter)
                .Include(bm => bm.FighterBlueTeam)
                .Include(bm => bm.FighterRedTeam)
                .ToArrayAsync<BoxingMatch>();
        }

        public async Task<BoxingMatch> GetByIdAsync(Guid id)
        {
            return await _db.BoxingMatches.FirstOrDefaultAsync(bm => bm.Id == id);
        }

        public async Task UpdateAsync(BoxingMatch entity)
        {
            _db.BoxingMatches.Update(entity);
            await _db.SaveChangesAsync();
        }
    }
}
