using FitPlanBuddy.Application.Dto.ExerciseDto;
using MediatR;

namespace FitPlanBuddy.Application.Features.Exercises.Queries.GetByIdWithDetails
{
    public class GetExerciseWithDetailsByIdRequest : IRequest<ExerciseWithDetailsRead>
    {
        public int Id { get; set; }

        public GetExerciseWithDetailsByIdRequest(int id)
        {
            Id = id;
        }
    }
}
