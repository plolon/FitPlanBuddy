using FitPlanBuddy.Application.Dto.ExerciseDto;
using FitPlanBuddy.Application.Features.Exercises.Queries.GetAll;
using FitPlanBuddy.Application.Features.Exercises.Queries.GetAllWithDetails;
using FitPlanBuddy.Application.Features.Exercises.Queries.GetById;
using FitPlanBuddy.Application.Features.Exercises.Queries.GetByIdWithDetails;
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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id, bool details) =>
            details == true ?
                Ok(await _mediator.Send(new GetExerciseWithDetailsByIdRequest(id))) :
                Ok(await _mediator.Send(new GetExerciseByIdRequest(id)));

        [HttpGet]
        public async Task<IActionResult> GetAll(bool details) =>
            details == true ?
                Ok(await _mediator.Send(new GetAllExercisesWithDetailsRequest())) :
                Ok(await _mediator.Send(new GetAllExercisesRequest()));
    }
}
