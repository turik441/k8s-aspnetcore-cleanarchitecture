using Application.Logic.Health.Query;
using Application.Responses.Health;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;

namespace Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        private readonly IMediator _mediator;
        public HealthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Ready to serve requests e.g. done warmup of cache etc.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("ready")]
        [ProducesResponseType(typeof(GetHealthResponse),(int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ProblemDetails), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Ready()
        {
            var result = await _mediator.Send(new GetHealthReadyQuery());
            return Ok(result);
        }

        /// <summary>
        /// Check that the ASP.NET runtime responds
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(GetHealthResponse), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ProblemDetails), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Alive()
        {
            var result = await _mediator.Send(new GetHealthAliveQuery());
            return Ok(result);
        }
    }
}
