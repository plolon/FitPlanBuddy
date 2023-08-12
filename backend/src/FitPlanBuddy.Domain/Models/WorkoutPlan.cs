namespace FitPlanBuddy.Domain.Models
{
    public class WorkoutPlan : DomainEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<WorkoutExercise> Exercises { get; set; }
    }
}
