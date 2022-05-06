using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Data.BaseRepository
{
    public interface IEntityBaseRepository<G> where G : class, IEntityBase, new() 
    {
        Task<IEnumerable<G>> GetAllAsync();

        Task<G> GetByIdAsync(int id);

        Task AddAsync(G entity);

        Task UpdateAsync(int id, G entity);

        Task DeleteAsync(int id);
    }
}
