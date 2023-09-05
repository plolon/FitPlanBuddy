using AutoMapper;
using FitPlanBuddy.Application.Dto.ExerciseDto;
using FitPlanBuddy.Domain.Models;
using FitPlanBuddy.Domain.Repositories;
using MediatR;

namespace FitPlanBuddy.Application.Features.Exercises.Commands.CreateExercise
{
    public class CreateExerciseHandler : IRequestHandler<CreateExerciseRequest, ExerciseRead>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateExerciseHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ExerciseRead> Handle(CreateExerciseRequest request, CancellationToken cancellationToken)
        {
            var exerciseRepo = _unitOfWork.ExerciseRepository;

            var mappedExercise = _mapper.Map<Exercise>(request.Exercise);
            var response = await exerciseRepo.CreateExerciseWithDetails(mappedExercise, request.Exercise.MusclePartsIds);

            await _unitOfWork.Complete();

            return _mapper.Map<ExerciseRead>(response);
        }
    }
}
