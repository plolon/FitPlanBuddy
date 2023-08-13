namespace FitPlanBuddy.Domain.Models
{
    public class ExerciseMuscleParts
    {
        public int ExerciseId { get; set; }
        public Exercise Exercise { get; set; }
        public int MusclePartId { get; set; }
        public MusclePart MusclePart { get; set; }
    }
}
