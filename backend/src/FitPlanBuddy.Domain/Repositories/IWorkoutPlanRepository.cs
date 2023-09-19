using FitPlanBuddy.Domain.Models;

namespace FitPlanBuddy.Domain.Repositories
{
    public interface IWorkoutPlanRepository : IGenericRepository<WorkoutPlan>
    {
        Task<WorkoutPlan> GetWithExercises(int id);

        Task<WorkoutPlan> AssignExercise(int workoutPlanId, int exerciseId, string reps, string series);
    }
}
