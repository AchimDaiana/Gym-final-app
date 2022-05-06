using Gym.Data.BaseRepository;
using Gym.Data.ViewModels;
using Gym.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Data.Services
{
    public interface ITrainingsServices : IEntityBaseRepository<Training>
    {
        Task<Training> GetTrainingByIdAsync(int id);

        Task<TrainingDropDownsVM> GetTrainingDropDownsData();

        Task AddTrainingAsync(TrainingVM data);

        Task UpdateTrainingAsync(TrainingVM data);
    }
}
