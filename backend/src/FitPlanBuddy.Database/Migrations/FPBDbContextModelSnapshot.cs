﻿// <auto-generated />
using FitPlanBuddy.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FitPlanBuddy.Database.Migrations
{
    [DbContext(typeof(FPBDbContext))]
    partial class FPBDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FitPlanBuddy.Domain.Models.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("FitPlanBuddy.Domain.Models.ExerciseMusclePart", b =>
                {
                    b.Property<int>("ExerciseId")
                        .HasColumnType("int");

                    b.Property<int>("MusclePartId")
                        .HasColumnType("int");

                    b.HasKey("ExerciseId", "MusclePartId");

                    b.HasIndex("MusclePartId");

                    b.ToTable("ExerciseMusclePart");
                });

            modelBuilder.Entity("FitPlanBuddy.Domain.Models.MusclePart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MuscleParts");
                });

            modelBuilder.Entity("FitPlanBuddy.Domain.Models.WorkoutExercise", b =>
                {
                    b.Property<int>("ExerciseId")
                        .HasColumnType("int");

                    b.Property<int>("WorkoutPlanId")
                        .HasColumnType("int");

                    b.Property<string>("Reps")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Series")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ExerciseId", "WorkoutPlanId");

                    b.HasIndex("WorkoutPlanId");

                    b.ToTable("WorkoutExercises");
                });

            modelBuilder.Entity("FitPlanBuddy.Domain.Models.WorkoutPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WorkoutPlans");
                });

            modelBuilder.Entity("FitPlanBuddy.Domain.Models.ExerciseMusclePart", b =>
                {
                    b.HasOne("FitPlanBuddy.Domain.Models.Exercise", null)
                        .WithMany()
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitPlanBuddy.Domain.Models.MusclePart", null)
                        .WithMany()
                        .HasForeignKey("MusclePartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FitPlanBuddy.Domain.Models.WorkoutExercise", b =>
                {
                    b.HasOne("FitPlanBuddy.Domain.Models.Exercise", null)
                        .WithMany("WorkoutExercises")
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitPlanBuddy.Domain.Models.WorkoutPlan", null)
                        .WithMany("WorkoutExercises")
                        .HasForeignKey("WorkoutPlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FitPlanBuddy.Domain.Models.Exercise", b =>
                {
                    b.Navigation("WorkoutExercises");
                });

            modelBuilder.Entity("FitPlanBuddy.Domain.Models.WorkoutPlan", b =>
                {
                    b.Navigation("WorkoutExercises");
                });
#pragma warning restore 612, 618
        }
    }
}
