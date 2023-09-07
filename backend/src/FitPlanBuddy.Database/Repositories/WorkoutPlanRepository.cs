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
            _dbContext = dbContext;
        }

        public async Task<WorkoutPlan> AssignExercise(int workoutPlanId, int exerciseId, string reps, string series)
        {
            var workoutPlan = await _dbContext.WorkoutPlans
                .Include(x => x.Exercises)
                .FirstOrDefaultAsync(x => x.Id.Equals(workoutPlanId));

            if (workoutPlan is null)
            {
                return null;
            }

            var exercise = await _dbContext.Exercises
                .Include(x => x.WorkoutExercises)
                .FirstOrDefaultAsync(x => x.Id.Equals(exerciseId));

            var workoutExercise = new WorkoutExercise()
            {
                ExerciseId = exerciseId,
                WorkoutPlanId = workoutPlanId,
                Reps = reps,
                Series = series
            };

            workoutPlan.Exercises.Add(exercise);
            _dbContext.WorkoutExercises.Add(workoutExercise);

            _dbContext.Update(workoutPlan);

            return workoutPlan;
        }

        public async Task<WorkoutPlan> GetWithExercises(int id)
        {
            return await _dbContext.WorkoutPlans
                .Include(x => x.Exercises)
                .Include(x => x.WorkoutExercises)
                .FirstOrDefaultAsync(x => x.Id.Equals(id));
        }
    }
}
