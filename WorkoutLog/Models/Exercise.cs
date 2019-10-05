using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WorkoutLog.Models
{
    public class Exercise
    {
        public string Workout { get; set; }
        public string Time { get; set; }
        public string Date { get; set; }
    }
}
