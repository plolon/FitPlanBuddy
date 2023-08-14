using FitPlanBuddy.Domain.Models;
using FitPlanBuddy.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FitPlanBuddy.Database.Repositories
{
    public class ExerciseRepository : IExerciseRepository
    {
        private readonly FPBDbContext _dbContext;

        public ExerciseRepository(FPBDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Exercise>> GetAllExercisesWithDetails()
        {
            return await _dbContext.Exercises
                .Include(x => x.MuscleParts).ToListAsync();
        }

        public async Task<Exercise> GetExerciseWithDetails(int id)
        {
            return await _dbContext.Exercises
                .Include(x => x.MuscleParts).FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
