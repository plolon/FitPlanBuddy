using FitPlanBuddy.Application.Dto.ExerciseDto;
using MediatR;

namespace FitPlanBuddy.Application.Features.Exercises.Queries.GetAllByMusclePart
{
    public class GetAllExercisesByMusclePartRequest : IRequest<IEnumerable<ExerciseRead>>
    {
        public int MusclePartId { get; set; }

        public GetAllExercisesByMusclePartRequest(int id)
        {
            MusclePartId = id;
        }
    }
}
