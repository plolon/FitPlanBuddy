namespace FitPlanBuddy.Domain.Models
{
    public class MusclePart : DomainEntity
    {
        public string Name { get; set; }
        public ICollection<Exercise> Exercises { get; set; }
    }
}
