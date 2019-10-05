using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutLog.Models
{
    public static class ExerciseRepository
    {
        private static List<Exercise> exercises = new List<Exercise>();

        public static IEnumerable<Exercise> Exercises
        {
            get { return exercises; }
        }
    

        public static void AddExercise(Exercise exercise)
        {
                exercises.Add(exercise);
        }
    }
}
