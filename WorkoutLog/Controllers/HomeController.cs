using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WorkoutLog.Models;

namespace WorkoutLog.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult WorkoutForm()
        {
            return View();
        }
       
        [HttpPost]
        public ViewResult WorkoutForm(Exercise exercise)
        {
            ExerciseRepository.AddExercise(exercise);
            return View("Added", exercise);
        }

        public ViewResult ListResponses()
        {
            return View(ExerciseRepository.Exercises.Select(e => e).ToList());
        }
        
    }
}
