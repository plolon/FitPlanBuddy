using FitPlanBuddy.Application.Dto.ExerciseDto;
using MediatR;

namespace FitPlanBuddy.Application.Features.Exercises.Queries.GetAll
{
    public class GetAllExercisesRequest : IRequest<IEnumerable<ExerciseRead>>
    {
    }
}
