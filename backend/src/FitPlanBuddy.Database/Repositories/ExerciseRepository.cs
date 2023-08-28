using FitPlanBuddy.Domain.Models;
using FitPlanBuddy.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FitPlanBuddy.Database.Repositories
{
    public class ExerciseRepository : GenericRepository<Exercise>, IExerciseRepository
    {
        private readonly FPBDbContext _dbContext;

        public ExerciseRepository(FPBDbContext dbContext) : base(dbContext)
        {
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
        public async Task<IEnumerable<Exercise>> GetExercisesByMusclePart(int id)
        {
            return _dbContext.Exercises.Where(x => x.MuscleParts.Any(x => x.Id.Equals(id)));
        }
    }
}
