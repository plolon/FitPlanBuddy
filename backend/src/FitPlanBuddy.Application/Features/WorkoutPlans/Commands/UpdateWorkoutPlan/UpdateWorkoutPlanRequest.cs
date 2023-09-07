using FitPlanBuddy.Application.Dto.WorkoutPlanDto;
using MediatR;

namespace FitPlanBuddy.Application.Features.WorkoutPlans.Commands.UpdateWorkoutPlan
{
    public class UpdateWorkoutPlanRequest : IRequest<WorkoutPlanRead>
    {
        public int Id { get; set; }
        public WorkoutPlanSave WorkoutPlan { get; set; }

        public UpdateWorkoutPlanRequest(int id, WorkoutPlanSave workoutPlan)
        {
            Id = id;
            WorkoutPlan = workoutPlan;
        }
    }
}
