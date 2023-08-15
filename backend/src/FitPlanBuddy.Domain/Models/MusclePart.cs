namespace FitPlanBuddy.Domain.Models
{
    public class MusclePart : DomainEntity
    {
        public string Name { get; set; }
        public IEnumerable<Exercise> Exercises { get; set; }
    }
}
