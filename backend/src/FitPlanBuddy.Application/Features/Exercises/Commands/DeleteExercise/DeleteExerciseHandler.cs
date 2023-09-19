using AutoMapper;
using FitPlanBuddy.Domain.Models;
using FitPlanBuddy.Domain.Repositories;
using MediatR;

namespace FitPlanBuddy.Application.Features.Exercises.Commands.DeleteExercise
{
    public class DeleteExerciseHandler : IRequestHandler<DeleteExerciseRequest, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public DeleteExerciseHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<bool> Handle(DeleteExerciseRequest request, CancellationToken cancellationToken)
        {
            var repo = await _unitOfWork.GetGenericRepositoryAsync<Exercise>();
            var response = await repo.DeleteById(request.Id);
            await _unitOfWork.Complete();

            return response;
        }
    }
}
