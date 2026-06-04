using Pin.LiveSports.Core.Entities;
using Pin.LiveSports.Infrastructure.Data;
using Pin.LiveSports.Infrastructure.Services.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.LiveSports.Infrastructure.Services
{
    public class BoxingMatchService : ICrudService<BoxingMatch>
    {
        private readonly BoxingDbContext _db;

        public BoxingMatchService(BoxingDbContext db)
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

        public IEnumerable<BoxingMatch> GetAll()
        {
            return _db.BoxingMatches.AsEnumerable<BoxingMatch>();
        }

        public async Task UpdateAsync(BoxingMatch entity)
        {
            _db.BoxingMatches.Update(entity);
            await _db.SaveChangesAsync();
        }
    }
}
