using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Data.BaseRepository
{
    public class EntityBaseRepository<G> : IEntityBaseRepository<G> where G : class, IEntityBase, new()
    {
        private readonly ApplicationDbContext _context;

        public EntityBaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(G entity)
        {
            await _context.Set<G>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async  Task DeleteAsync(int id)
        {
            var entity = await _context.Set<G>().FirstOrDefaultAsync(m => m.Id == id);
            EntityEntry entityEntry = _context.Entry<G>(entity);
            entityEntry.State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<G>> GetAllAsync()
        {
            var outcome = await _context.Set<G>().ToListAsync();
            return outcome;
        }

        public async Task<G> GetByIdAsync(int id)
        {
            var outcome = await _context.Set<G>().FirstOrDefaultAsync(m => m.Id == id);
            return outcome;
        }

        public async Task UpdateAsync(int id, G entity)
        {

            EntityEntry entityEntry = _context.Entry<G>(entity);
            entityEntry.State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
