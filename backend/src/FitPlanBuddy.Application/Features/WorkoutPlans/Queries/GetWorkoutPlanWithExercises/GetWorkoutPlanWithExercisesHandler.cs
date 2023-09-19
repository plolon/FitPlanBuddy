using AutoMapper;
using FitPlanBuddy.Application.Dto.WorkoutPlanDto;
using FitPlanBuddy.Domain.Models;
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

            var response = _mapper.Map<WorkoutPlanWithExercisesRead>(workoutPlan);
            response = MapRepsAndSeriesToResponse(response, workoutPlan);

            return response;
        }

        private WorkoutPlanWithExercisesRead MapRepsAndSeriesToResponse(WorkoutPlanWithExercisesRead response, WorkoutPlan workoutPlan)
        {
            foreach (var exercise in response.Exercises)
            {
                var workoutExercise = workoutPlan.WorkoutExercises.FirstOrDefault(x => x.WorkoutPlanId.Equals(response.Id) && x.ExerciseId.Equals(exercise.Id));
                if (workoutExercise is not null)
                {
                    exercise.Reps = workoutExercise.Reps;
                    exercise.Series = workoutExercise.Series;
                }
            }
            return response;
        }
    }
}
