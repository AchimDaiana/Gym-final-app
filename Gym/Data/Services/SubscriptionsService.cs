using Gym.Data.BaseRepository;
using Gym.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Data.Services
{
    public class SubscriptionsService : EntityBaseRepository<Subscription>, ISubscriptionsServices
    {
        public SubscriptionsService(ApplicationDbContext context) : base(context)
        {
        }
    }
}
