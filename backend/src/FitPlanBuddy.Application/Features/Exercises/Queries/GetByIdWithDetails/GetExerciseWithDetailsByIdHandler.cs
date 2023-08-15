using AutoMapper;
using FitPlanBuddy.Application.Dto.ExerciseDto;
using FitPlanBuddy.Domain.Repositories;
using MediatR;

namespace FitPlanBuddy.Application.Features.Exercises.Queries.GetByIdWithDetails
{
    public class GetExerciseWithDetailsByIdHandler : IRequestHandler<GetExerciseWithDetailsByIdRequest, ExerciseWithDetailsRead>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetExerciseWithDetailsByIdHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ExerciseWithDetailsRead> Handle(GetExerciseWithDetailsByIdRequest request, CancellationToken cancellationToken)
        {
            var repo = _unitOfWork.ExerciseRepository;
            var exercise = await repo.GetExerciseWithDetails(request.Id);
            return _mapper.Map<ExerciseWithDetailsRead>(exercise);
        }
    }
}
