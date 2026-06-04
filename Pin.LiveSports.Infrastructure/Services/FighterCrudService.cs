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
    public class FighterCrudService : ICrudService<Fighter>
    {
        private readonly BoxingDbContext _db;

        public FighterCrudService(BoxingDbContext db)
        {
            _db = db;
        }

        public async Task AddAsync(Fighter entity)
        {
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
            return await _db.Fighters.ToArrayAsync<Fighter>();
        }

        public async Task UpdateAsync(Fighter entity)
        {
            _db.Fighters.Update(entity);
            await _db.SaveChangesAsync();
        }
    }
}
