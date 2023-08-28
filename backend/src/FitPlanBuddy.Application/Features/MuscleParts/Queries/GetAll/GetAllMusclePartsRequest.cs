using FitPlanBuddy.Application.Dto.MusclePartDto;
using MediatR;

namespace FitPlanBuddy.Application.Features.MuscleParts.Queries.GetAll
{
    public class GetAllMusclePartsRequest : IRequest<IEnumerable<MusclePartRead>>
    {
    }
}
