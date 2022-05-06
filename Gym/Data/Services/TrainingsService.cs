using Gym.Data.BaseRepository;
using Gym.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Data.Services
{
    public class TrainingsService : EntityBaseRepository<Training>, ITrainingsServices
    {
        private readonly ApplicationDbContext _context;

        public TrainingsService(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Training> GetTrainingByIdAsync(int id)
        {
            var trainingDetails = await _context.Trainings
                .Include(b => b.Trainer)
                .Include(c => c.Subscription)
                .FirstOrDefaultAsync(m => m.Id == id);

            return trainingDetails;
        }
    }
}
