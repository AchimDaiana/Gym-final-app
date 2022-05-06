using Gym.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Trainer> Trainers { get; set; }

        public DbSet<Training> Trainings { get; set; }

        public DbSet<Subscription> Subscriptions { get; set; }

        public DbSet<Reservation> Reservations { get; set; }

    }
}
