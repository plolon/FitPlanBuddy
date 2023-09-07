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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WorkoutExercise>().HasKey(q => new { q.ExerciseId, q.WorkoutPlanId });

            modelBuilder.Entity<Exercise>()
                .HasMany(x => x.MuscleParts)
                .WithMany(x => x.Exercises)
                .UsingEntity<ExerciseMusclePart>();

            modelBuilder.Entity<WorkoutPlan>()
                .HasMany(x => x.Exercises)
                .WithMany(x => x.WorkoutPlans)
                .UsingEntity<WorkoutExercise>();


            base.OnModelCreating(modelBuilder);
        }
    }   
}
