namespace FitPlanBuddy.Domain.Models
{
    public class WorkoutPlan : DomainEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<Exercise> Exercises { get; set; }
    }
}
