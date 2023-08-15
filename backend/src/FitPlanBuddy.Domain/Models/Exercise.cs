namespace FitPlanBuddy.Domain.Models
{
    public class Exercise : DomainEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<MusclePart> MuscleParts { get; set; }
        public IEnumerable<WorkoutPlan> WorkoutPlans { get; set; }
    }
}
