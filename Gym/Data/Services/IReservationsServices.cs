using Gym.Data.BaseRepository;
using Gym.Data.ViewModels;
using Gym.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Data.Services
{
    public interface IReservationsServices : IEntityBaseRepository<Reservation>
    {
        Task<Reservation> GetReservationByIdAsync(int id);
        Task<ReservationDropDownsVM> GetReservationDropDownsData();
        Task AddReservationAsync(ReservationVM data);
        Task UpdateReservationAsync(ReservationVM data);
    }
}
