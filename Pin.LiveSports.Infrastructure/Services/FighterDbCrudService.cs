using Pin.LiveSports.Core.Entities;
using Pin.LiveSports.Infrastructure.Data;
using Pin.LiveSports.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Pin.LiveSports.Infrastructure.Services
{
    public class FighterDbCrudService : ICrudService<Fighter>
    {
        private readonly BoxingDbContext _db;

        public FighterDbCrudService(BoxingDbContext db)
        {
            _db = db;
        }

        public async Task AddAsync(Fighter entity)
        {
            entity.Id = Guid.NewGuid();
            await _db.Fighters.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(Fighter entity)
        {
            _db.Fighters.Remove(entity);
            await _db.SaveChangesAsync();
        }

        public async Task<Fighter[]> GetAllAsync()
        {
            return await _db
                .Fighters
                .ToArrayAsync<Fighter>();
        }

        public async Task<Fighter> GetByIdAsync(Guid id)
        {
            return await _db.Fighters.FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task UpdateAsync(Fighter entity)
        {
            _db.Fighters.Update(entity);
            await _db.SaveChangesAsync();
        }
    }
}
