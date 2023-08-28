using FitPlanBuddy.Domain.Models;
using FitPlanBuddy.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FitPlanBuddy.Database.Repositories
{
    public class WorkoutPlanRepository : GenericRepository<WorkoutPlan>, IWorkoutPlanRepository
    {
        private readonly FPBDbContext _dbContext;
        public WorkoutPlanRepository(FPBDbContext dbContext) : base(dbContext)
        {
            _dbContext= dbContext;
        }

        public async Task<WorkoutPlan> GetWithExercises(int id)
        {
            return await _dbContext.WorkoutPlans.Include(x => x.Exercises).FirstOrDefaultAsync(x => x.Id.Equals(id));
        }
    }
}
