using AutoMapper;
using FitPlanBuddy.Application.Dto.ExerciseDto;
using FitPlanBuddy.Domain.Models;
using FitPlanBuddy.Domain.Repositories;
using MediatR;

namespace FitPlanBuddy.Application.Features.Exercises.Queries.GetById
{
    public class GetExerciseByIdHandler : IRequestHandler<GetExerciseByIdRequest, ExerciseRead>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetExerciseByIdHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ExerciseRead> Handle(GetExerciseByIdRequest request, CancellationToken cancellationToken)
        {
            var repo = await _unitOfWork.GetGenericRepositoryAsync<Exercise>();
            var exercise = await repo.GetById(request.Id);
            return _mapper.Map<ExerciseRead>(exercise);
        }
    }
}
