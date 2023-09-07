using MediatR;

namespace FitPlanBuddy.Application.Features.WorkoutPlans.Commands.DeleteWorkoutPlan
{
    public class DeleteWorkoutPlanRequest : IRequest<bool>
    {
        public int Id { get; set; }

        public DeleteWorkoutPlanRequest(int id)
        {
            Id = id;
        }
    }
}
