using AutoMapper;
using FitPlanBuddy.Application.Dto.WorkoutPlanDto;
using FitPlanBuddy.Domain.Models;
using FitPlanBuddy.Domain.Repositories;
using MediatR;

namespace FitPlanBuddy.Application.Features.WorkoutPlans.Commands.CreateWorkoutPlan
{
    public class CreateWorkoutPlanHandler : IRequestHandler<CreateWorkoutPlanRequest, WorkoutPlanRead>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateWorkoutPlanHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<WorkoutPlanRead> Handle(CreateWorkoutPlanRequest request, CancellationToken cancellationToken)
        {
            var repo = await _unitOfWork.GetGenericRepositoryAsync<WorkoutPlan>();

            var workoutPlan = _mapper.Map<WorkoutPlan>(request.WorkoutPlan);
            var response = await repo.Create(workoutPlan);

            await _unitOfWork.Complete();

            return _mapper.Map<WorkoutPlanRead>(response);
        }
    }
}
