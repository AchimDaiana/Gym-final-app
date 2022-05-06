﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime ParticipationHour { get; set; }

        public DateTime ParticipationDate { get; set; }

        //relatia cu clasele
        public int TrainingId { get; set; }
        public Training Training { get; set; }
    }
}
