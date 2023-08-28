using FitPlanBuddy.Application.Dto.WorkoutPlanDto;
using MediatR;

namespace FitPlanBuddy.Application.Features.WorkoutPlans.Queries.GetAll
{
    public class GetAllWorkoutPlansRequest : IRequest<IEnumerable<WorkoutPlanRead>>
    {
    }
}
