namespace FitPlanBuddy.Domain.Models
{
    public class WorkoutExercise
    {
        public int ExerciseId { get; set; }
        public Exercise Exercise { get; set; }
        public int WorkoutPlanId { get; set; }
        public WorkoutPlan WorkoutPlan { get; set; }
        public string Reps { get; set; }
        public string Series { get; set; }
    }
}
