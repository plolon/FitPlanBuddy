using FitPlanBuddy.Application.Dto.ExerciseDto;
using FitPlanBuddy.Application.Features.Exercises.Queries.GetAll;
using FitPlanBuddy.Application.Features.Exercises.Queries.GetAllWithDetails;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FitPlanBuddy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExercisesController : ControllerBase
    {
        private readonly ISender _mediator;

        public ExercisesController(ISender sender)
        {
            _mediator = sender;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(bool details) =>
            details == true ?
                Ok(await _mediator.Send(new GetAllExercisesWithDetailsRequest())) :
                Ok(await _mediator.Send(new GetAllExercisesRequest()));
    }
}
