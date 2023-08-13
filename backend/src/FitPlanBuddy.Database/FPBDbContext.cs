using FitPlanBuddy.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace FitPlanBuddy.Database
{
    public class FPBDbContext : DbContext
    {
        public FPBDbContext(DbContextOptions<FPBDbContext> options) : base(options) { }

        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<MusclePart> MuscleParts { get; set; }
        public DbSet<WorkoutExercise> WorkoutExercises { get; set; }
        public DbSet<WorkoutPlan> WorkoutPlans { get; set; }
    }   
}
