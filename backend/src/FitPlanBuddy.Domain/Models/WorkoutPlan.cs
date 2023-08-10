﻿namespace FitPlanBuddy.Domain.Models
{
    public class WorkoutPlan
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<WorkoutExercise> Exercises { get; set; }
    }
}
