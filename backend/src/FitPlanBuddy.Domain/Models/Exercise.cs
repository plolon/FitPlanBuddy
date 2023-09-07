namespace FitPlanBuddy.Domain.Models
{
    public class Exercise : DomainEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<MusclePart> MuscleParts { get; set; }
        public virtual ICollection<WorkoutPlan> WorkoutPlans { get; set; }
        public virtual ICollection<WorkoutExercise> WorkoutExercises { get; set; }
    }
}
