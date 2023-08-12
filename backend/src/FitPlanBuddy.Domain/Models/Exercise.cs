namespace FitPlanBuddy.Domain.Models
{
    public class Exercise : DomainEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        IEnumerable<MusclePart> MuscleParts { get; set; }
    }
}
