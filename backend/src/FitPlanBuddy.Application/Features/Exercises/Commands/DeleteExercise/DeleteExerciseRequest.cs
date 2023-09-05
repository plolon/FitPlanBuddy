using MediatR;

namespace FitPlanBuddy.Application.Features.Exercises.Commands.DeleteExercise
{
    public class DeleteExerciseRequest : IRequest<bool>
    {
        public int Id { get; set; }

        public DeleteExerciseRequest(int id)
        {
            Id = id;
        }
    }
}
