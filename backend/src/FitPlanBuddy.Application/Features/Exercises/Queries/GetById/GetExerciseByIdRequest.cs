using FitPlanBuddy.Application.Dto.ExerciseDto;
using MediatR;

namespace FitPlanBuddy.Application.Features.Exercises.Queries.GetById
{
    public class GetExerciseByIdRequest : IRequest<ExerciseRead>
    {
        public int Id { get; set; }

        public GetExerciseByIdRequest(int id)
        {
            Id = id;
        }
    }
}
