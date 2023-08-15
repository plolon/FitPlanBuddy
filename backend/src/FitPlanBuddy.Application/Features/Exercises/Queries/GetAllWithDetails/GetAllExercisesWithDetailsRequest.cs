using FitPlanBuddy.Application.Dto.ExerciseDto;
using MediatR;

namespace FitPlanBuddy.Application.Features.Exercises.Queries.GetAllWithDetails
{
    public class GetAllExercisesWithDetailsRequest : IRequest<IEnumerable<ExerciseWithDetailsRead>>
    {
    }
}
