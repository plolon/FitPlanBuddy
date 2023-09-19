using FitPlanBuddy.Application.Dto.WorkoutPlanDto;
using MediatR;

namespace FitPlanBuddy.Application.Features.WorkoutPlans.Commands.AssignExercise
{
    public class AssignExerciseRequest : IRequest<WorkoutPlanRead>
    {
        public AssignExerciseDto AssignExercise { get; set; }

        public AssignExerciseRequest(AssignExerciseDto assignExercise)
        {
            AssignExercise = assignExercise;
        }
    }
}
