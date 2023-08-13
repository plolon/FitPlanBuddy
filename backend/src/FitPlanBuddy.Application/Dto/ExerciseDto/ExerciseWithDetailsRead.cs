using FitPlanBuddy.Application.Dto.MusclePartDto;

namespace FitPlanBuddy.Application.Dto.ExerciseDto
{
    public class ExerciseWithDetailsRead
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        IEnumerable<MusclePartRead> MuscleParts { get; set; }
    }
}
