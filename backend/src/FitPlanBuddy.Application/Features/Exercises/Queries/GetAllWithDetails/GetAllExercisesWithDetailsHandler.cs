using AutoMapper;
using FitPlanBuddy.Application.Dto.ExerciseDto;
using FitPlanBuddy.Domain.Repositories;
using MediatR;

namespace FitPlanBuddy.Application.Features.Exercises.Queries.GetAllWithDetails
{
    public class GetAllExercisesWithDetailsHandler : IRequestHandler<GetAllExercisesWithDetailsRequest, IEnumerable<ExerciseWithDetailsRead>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllExercisesWithDetailsHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ExerciseWithDetailsRead>> Handle(GetAllExercisesWithDetailsRequest request, CancellationToken cancellationToken)
        {
            var exercises = await _unitOfWork.ExerciseRepository.GetAllExercisesWithDetails();
            return _mapper.Map<IEnumerable<ExerciseWithDetailsRead>>(exercises);
        }
    }
}
