using FitPlanBuddy.Domain.Models;

namespace FitPlanBuddy.Application.Dto.WorkoutPlanDto
{
    public class WorkoutPlanWithExercisesRead
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<Exercise> Exercises { get; set; }

    }
}
