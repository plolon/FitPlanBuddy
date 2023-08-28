using FitPlanBuddy.Application.Features.WorkoutPlans.Queries.GetAll;
using FitPlanBuddy.Application.Features.WorkoutPlans.Queries.GetWorkoutPlanWithExercises;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FitPlanBuddy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkoutPlansController : ControllerBase
    {
        private readonly ISender _mediator;
        public WorkoutPlansController(ISender mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _mediator.Send(new GetAllWorkoutPlansRequest()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _mediator.Send(new GetWorkoutPlanWithExercisesRequest(id)));
        }
    }
}
