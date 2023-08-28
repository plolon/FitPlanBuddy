using FitPlanBuddy.Application.Dto.WorkoutPlanDto;
using MediatR;

namespace FitPlanBuddy.Application.Features.WorkoutPlans.Queries.GetWorkoutPlanWithExercises
{
    public class GetWorkoutPlanWithExercisesRequest : IRequest<WorkoutPlanWithExercisesRead>
    {
        public GetWorkoutPlanWithExercisesRequest(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
