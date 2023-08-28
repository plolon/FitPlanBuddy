using AutoMapper;
using FitPlanBuddy.Application.Dto.ExerciseDto;
using FitPlanBuddy.Domain.Repositories;
using MediatR;

namespace FitPlanBuddy.Application.Features.Exercises.Queries.GetAllByMusclePart
{
    public class GetAllExercisesByMusclePartHandler : IRequestHandler<GetAllExercisesByMusclePartRequest, IEnumerable<ExerciseRead>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public GetAllExercisesByMusclePartHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ExerciseRead>> Handle(GetAllExercisesByMusclePartRequest request, CancellationToken cancellationToken)
        {
            var repo = _unitOfWork.ExerciseRepository;
            var exercises = await repo.GetExercisesByMusclePart(request.MusclePartId);
            return _mapper.Map<IEnumerable<ExerciseRead>>(exercises);
        }
    }
}
