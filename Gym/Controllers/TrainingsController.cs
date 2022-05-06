using Gym.Data;
using Gym.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Controllers
{
    public class TrainingsController : Controller
    {
        private readonly ITrainingsServices _service;

        public TrainingsController(ITrainingsServices service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allTrainings = await _service.GetAllAsync();
            return View(allTrainings);
        }

        //get/training/details
        public async Task<IActionResult> Details(int id)
        {
            var trainingDetails = await _service.GetTrainingByIdAsync(id);
            return View(trainingDetails);

        }

        public IActionResult Create()
        {
            return View();
        }

    }
}
