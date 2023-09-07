using FitPlanBuddy.Application.Dto.WorkoutPlanDto;
using MediatR;

namespace FitPlanBuddy.Application.Features.WorkoutPlans.Commands.CreateWorkoutPlan
{
    public class CreateWorkoutPlanRequest : IRequest<WorkoutPlanRead>
    {
        public WorkoutPlanSave WorkoutPlan { get; set; }

        public CreateWorkoutPlanRequest(WorkoutPlanSave workoutPlan)
        {
            WorkoutPlan = workoutPlan;
        }
    }
}
