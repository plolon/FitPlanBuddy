using FitPlanBuddy.Application.Features.MuscleParts.Queries.GetAll;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FitPlanBuddy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusclePartsController : ControllerBase
    {
        private readonly ISender _mediator;
        public MusclePartsController(ISender mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _mediator.Send(new GetAllMusclePartsRequest()));
        }
    }
}
