using AutoMapper;
using FitPlanBuddy.Application.Dto.WorkoutPlanDto;
using FitPlanBuddy.Domain.Models;
using FitPlanBuddy.Domain.Repositories;
using MediatR;

namespace FitPlanBuddy.Application.Features.WorkoutPlans.Commands.UpdateWorkoutPlan
{
    public class UpdateWorkoutPlanHandler : IRequestHandler<UpdateWorkoutPlanRequest, WorkoutPlanRead>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateWorkoutPlanHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<WorkoutPlanRead> Handle(UpdateWorkoutPlanRequest request, CancellationToken cancellationToken)
        {
            var workoutPlanRepo = await _unitOfWork.GetGenericRepositoryAsync<WorkoutPlan>();

            var workoutPlanSrc = await workoutPlanRepo.GetById(request.Id);

            _mapper.Map(request.WorkoutPlan, workoutPlanSrc);

            var response = await workoutPlanRepo.Update(workoutPlanSrc);

            await _unitOfWork.Complete();

            return _mapper.Map<WorkoutPlanRead>(response);
        }
    }
}
