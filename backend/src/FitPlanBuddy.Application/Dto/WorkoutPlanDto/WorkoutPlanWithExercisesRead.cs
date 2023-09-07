using FitPlanBuddy.Application.Dto.ExerciseDto;

namespace FitPlanBuddy.Application.Dto.WorkoutPlanDto
{
    public class WorkoutPlanWithExercisesRead
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<ExerciseWithDataRead> Exercises { get; set; }

    }
}
