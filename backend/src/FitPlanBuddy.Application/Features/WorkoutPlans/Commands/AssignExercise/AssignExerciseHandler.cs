using AutoMapper;
using FitPlanBuddy.Application.Dto.WorkoutPlanDto;
using FitPlanBuddy.Domain.Repositories;
using MediatR;

namespace FitPlanBuddy.Application.Features.WorkoutPlans.Commands.AssignExercise
{
    public class AssignExerciseHandler : IRequestHandler<AssignExerciseRequest, WorkoutPlanRead>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AssignExerciseHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<WorkoutPlanRead> Handle(AssignExerciseRequest request, CancellationToken cancellationToken)
        {
            var repo = _unitOfWork.WorkoutPlanRepository;

            var response = await repo.AssignExercise(
                request.AssignExercise.WorkoutPlanId,
                request.AssignExercise.ExerciseId,
                request.AssignExercise.Reps,
                request.AssignExercise.Series);


            await _unitOfWork.Complete();

            return _mapper.Map<WorkoutPlanRead>(response);

        }
    }
}
