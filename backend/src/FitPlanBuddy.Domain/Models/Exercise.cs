namespace FitPlanBuddy.Domain.Models
{
    public class Exercise
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        IEnumerable<MusclePart> MuscleParts { get; set; }
    }
}
