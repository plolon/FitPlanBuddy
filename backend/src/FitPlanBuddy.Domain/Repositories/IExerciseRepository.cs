﻿using FitPlanBuddy.Domain.Models;

namespace FitPlanBuddy.Domain.Repositories
{
    public interface IExerciseRepository
    {
        Task<IEnumerable<Exercise>> GetAllExercisesWithDetails();
        Task<Exercise> GetExerciseWithDetails(int id);
        Task<IEnumerable<Exercise>> GetExercisesByMusclePart(int id);
    }
}
