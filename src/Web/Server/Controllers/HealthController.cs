using Application.Responses;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        // If the process ready to serve requests e.g. done warmup of cache etc.
        [HttpGet]
        [Route("ready")]
        public async Task<IActionResult> Ready()
        {
            return await Task.FromResult(Ok(new HealthResponse
            {
                Message = "Yes. Ready now."
            }));
        }

        // Check that the ASP.NET runtime responds
        [HttpGet]
        public async Task<IActionResult> Alive()
        {
            return await Task.FromResult(Ok(new HealthResponse
            {
                Message = "Alive. All is well."
            }));          
        }
    }
}
