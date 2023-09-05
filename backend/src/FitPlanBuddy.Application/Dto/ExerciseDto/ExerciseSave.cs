namespace FitPlanBuddy.Application.Dto.ExerciseDto
{
    public class ExerciseSave
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<int> MusclePartsIds { get; set; }
    }
}
