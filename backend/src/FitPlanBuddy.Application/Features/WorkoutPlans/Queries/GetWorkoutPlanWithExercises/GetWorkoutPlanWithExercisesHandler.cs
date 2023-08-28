using AutoMapper;
using FitPlanBuddy.Application.Dto.WorkoutPlanDto;
using FitPlanBuddy.Domain.Repositories;
using MediatR;

namespace FitPlanBuddy.Application.Features.WorkoutPlans.Queries.GetWorkoutPlanWithExercises
{
    public class GetWorkoutPlanWithExercisesHandler : IRequestHandler<GetWorkoutPlanWithExercisesRequest, WorkoutPlanWithExercisesRead>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetWorkoutPlanWithExercisesHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<WorkoutPlanWithExercisesRead> Handle(GetWorkoutPlanWithExercisesRequest request, CancellationToken cancellationToken)
        {
            var repo = _unitOfWork.WorkoutPlanRepository;
            var workoutPlan = await repo.GetWithExercises(request.Id);
            return _mapper.Map<WorkoutPlanWithExercisesRead>(workoutPlan);
        }
    }
}
