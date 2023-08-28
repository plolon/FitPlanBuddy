using FitPlanBuddy.Domain.Models;

namespace FitPlanBuddy.Domain.Repositories
{
    public interface IWorkoutPlanRepository : IGenericRepository<WorkoutPlan>
    {
        Task<WorkoutPlan> GetWithExercises(int id);
    }
}
