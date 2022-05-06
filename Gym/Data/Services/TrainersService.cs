using Gym.Data.BaseRepository;
using Gym.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Data.Services
{
    public class TrainersService : EntityBaseRepository<Trainer>, ITrainersServices
    {
        private readonly ApplicationDbContext _context;

        public TrainersService(ApplicationDbContext context) : base(context)
        {    
        }

    }
}
