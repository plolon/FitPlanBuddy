using AutoMapper;
using FitPlanBuddy.Application.Dto.MusclePartDto;
using FitPlanBuddy.Domain.Models;
using FitPlanBuddy.Domain.Repositories;
using MediatR;

namespace FitPlanBuddy.Application.Features.MuscleParts.Queries.GetAll
{
    public class GetAllMusclePartsHandler : IRequestHandler<GetAllMusclePartsRequest, IEnumerable<MusclePartRead>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public GetAllMusclePartsHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<MusclePartRead>> Handle(GetAllMusclePartsRequest request, CancellationToken cancellationToken)
        {
            var repo = await _unitOfWork.GetGenericRepositoryAsync<MusclePart>();
            var muscleParts = await repo.GetAll();
            return _mapper.Map<IEnumerable<MusclePartRead>>(muscleParts);
        }
    }
}
