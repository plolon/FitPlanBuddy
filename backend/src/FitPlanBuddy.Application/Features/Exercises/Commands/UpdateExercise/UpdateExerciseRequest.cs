using FitPlanBuddy.Application.Dto.ExerciseDto;
using MediatR;

namespace FitPlanBuddy.Application.Features.Exercises.Commands.UpdateExercise
{
    public class UpdateExerciseRequest : IRequest<ExerciseRead>
    {
        public int Id { get; set; }
        public ExerciseSave Exercise { get; set; }

        public UpdateExerciseRequest(int id, ExerciseSave exercise)
        {
            Id = id;
            Exercise = exercise;
        }
    }
}
