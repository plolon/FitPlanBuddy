using AutoMapper;
using FitPlanBuddy.Domain.Models;
using FitPlanBuddy.Domain.Repositories;
using MediatR;

namespace FitPlanBuddy.Application.Features.WorkoutPlans.Commands.DeleteWorkoutPlan
{
    public class DeleteWorkoutPlanHandler : IRequestHandler<DeleteWorkoutPlanRequest, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DeleteWorkoutPlanHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<bool> Handle(DeleteWorkoutPlanRequest request, CancellationToken cancellationToken)
        {
            var repo = await _unitOfWork.GetGenericRepositoryAsync<WorkoutPlan>();

            var respone = await repo.DeleteById(request.Id);

            if (respone)
            {
                await _unitOfWork.Complete();
            }

            return respone;
        }
    }
}
