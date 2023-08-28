using AutoMapper;
using FitPlanBuddy.Application.Dto.WorkoutPlanDto;
using FitPlanBuddy.Domain.Models;
using FitPlanBuddy.Domain.Repositories;
using MediatR;

namespace FitPlanBuddy.Application.Features.WorkoutPlans.Queries.GetAll
{
    public class GetAllWorkoutPlansHandler : IRequestHandler<GetAllWorkoutPlansRequest, IEnumerable<WorkoutPlanRead>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllWorkoutPlansHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<WorkoutPlanRead>> Handle(GetAllWorkoutPlansRequest request, CancellationToken cancellationToken)
        {
            var repo = await _unitOfWork.GetGenericRepositoryAsync<WorkoutPlan>();
            var workoutPlans = await repo.GetAll();
            return _mapper.Map<IEnumerable<WorkoutPlanRead>>(workoutPlans);
        }
    }
}
