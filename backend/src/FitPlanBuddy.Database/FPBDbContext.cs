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
            modelBuilder.Entity<Exercise>()
                .HasMany(x => x.MuscleParts)
                .WithMany(x => x.Exercises)
                .UsingEntity<ExerciseMusclePart>(
                    x => x.HasOne<MusclePart>().WithMany().HasForeignKey(x => x.MusclePartId),
                    x => x.HasOne<Exercise>().WithMany().HasForeignKey(x => x.ExerciseId));

            modelBuilder.Entity<WorkoutPlan>()
                .HasMany(x => x.Exercises)
                .WithMany(x => x.WorkoutPlans)
                .UsingEntity<WorkoutExercise>(
                    x => x.HasOne<Exercise>().WithMany().HasForeignKey(x => x.ExerciseId),
                    x => x.HasOne<WorkoutPlan>().WithMany().HasForeignKey(x => x.WorkoutPlanId));

            base.OnModelCreating(modelBuilder);
        }
    }   
}
