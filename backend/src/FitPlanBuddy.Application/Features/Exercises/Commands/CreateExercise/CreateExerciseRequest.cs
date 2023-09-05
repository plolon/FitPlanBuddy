using FitPlanBuddy.Application.Dto.ExerciseDto;
using MediatR;

namespace FitPlanBuddy.Application.Features.Exercises.Commands.CreateExercise
{
    public class CreateExerciseRequest :IRequest<ExerciseRead>
    {
        public ExerciseSave Exercise { get; set; }

        public CreateExerciseRequest(ExerciseSave exercise)
        {
            Exercise = exercise;
        }
    }
}
