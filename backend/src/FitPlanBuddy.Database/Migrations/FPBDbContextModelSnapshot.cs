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

                    b.Property<int>("ExerciseId1")
                        .HasColumnType("int");

                    b.Property<int>("MusclePartId1")
                        .HasColumnType("int");

                    b.HasKey("ExerciseId", "MusclePartId");

                    b.HasIndex("ExerciseId1");

                    b.HasIndex("MusclePartId");

                    b.HasIndex("MusclePartId1");

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

                    b.Property<int>("ExerciseId1")
                        .HasColumnType("int");

                    b.Property<string>("Reps")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Series")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WorkoutPlanId1")
                        .HasColumnType("int");

                    b.HasKey("ExerciseId", "WorkoutPlanId");

                    b.HasIndex("ExerciseId1");

                    b.HasIndex("WorkoutPlanId");

                    b.HasIndex("WorkoutPlanId1");

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

                    b.HasOne("FitPlanBuddy.Domain.Models.Exercise", "Exercise")
                        .WithMany()
                        .HasForeignKey("ExerciseId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitPlanBuddy.Domain.Models.MusclePart", null)
                        .WithMany()
                        .HasForeignKey("MusclePartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitPlanBuddy.Domain.Models.MusclePart", "MusclePart")
                        .WithMany()
                        .HasForeignKey("MusclePartId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exercise");

                    b.Navigation("MusclePart");
                });

            modelBuilder.Entity("FitPlanBuddy.Domain.Models.WorkoutExercise", b =>
                {
                    b.HasOne("FitPlanBuddy.Domain.Models.Exercise", null)
                        .WithMany()
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitPlanBuddy.Domain.Models.Exercise", "Exercise")
                        .WithMany()
                        .HasForeignKey("ExerciseId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitPlanBuddy.Domain.Models.WorkoutPlan", null)
                        .WithMany()
                        .HasForeignKey("WorkoutPlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitPlanBuddy.Domain.Models.WorkoutPlan", "WorkoutPlan")
                        .WithMany()
                        .HasForeignKey("WorkoutPlanId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exercise");

                    b.Navigation("WorkoutPlan");
                });
#pragma warning restore 612, 618
        }
    }
}
