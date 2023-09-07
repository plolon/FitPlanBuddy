namespace FitPlanBuddy.Application.Dto.WorkoutPlanDto
{
    public class AssignExerciseDto
    {
        public int WorkoutPlanId { get; set; }
        public int ExerciseId { get; set; }
        public string Reps { get; set; }
        public string Series { get; set; }
    }
}
