using AutoMapper;
using FitPlanBuddy.Application.Dto.ExerciseDto;
using FitPlanBuddy.Domain.Models;
using FitPlanBuddy.Domain.Repositories;
using MediatR;

namespace FitPlanBuddy.Application.Features.Exercises.Commands.UpdateExercise
{
    public class UpdateExerciseHandler : IRequestHandler<UpdateExerciseRequest, ExerciseRead>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateExerciseHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ExerciseRead> Handle(UpdateExerciseRequest request, CancellationToken cancellationToken)
        {
            var exerciseRepo = _unitOfWork.ExerciseRepository;

            var exerciseSrc = await exerciseRepo.GetExerciseWithDetails(request.Id);

            _mapper.Map(request.Exercise, exerciseSrc);

            var response = await exerciseRepo.UpdateExerciseWithDetails(exerciseSrc, request.Exercise.MusclePartsIds);

            await _unitOfWork.Complete();

            return _mapper.Map<ExerciseRead>(response);
        }
    }
}
