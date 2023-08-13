using AutoMapper;
using FitPlanBuddy.Application.Dto.ExerciseDto;
using FitPlanBuddy.Domain.Models;
using FitPlanBuddy.Domain.Repositories;
using MediatR;

namespace FitPlanBuddy.Application.Features.Exercises.Queries.GetAll
{
    public class GetAllExercisesHandler : IRequestHandler<GetAllExercisesRequest, IEnumerable<ExerciseRead>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllExercisesHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ExerciseRead>> Handle(GetAllExercisesRequest request, CancellationToken cancellationToken)
        {
            var repo = await _unitOfWork.GetGenericRepositoryAsync<Exercise>();
            var exercises = await repo.GetAll();
            return _mapper.Map<IEnumerable<ExerciseRead>>(exercises);
        }
    }
}
