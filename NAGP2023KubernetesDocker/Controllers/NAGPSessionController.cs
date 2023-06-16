using Microsoft.AspNetCore.Mvc;
using NAGP2023KubernetesDocker.Models;
using NAGP2023KubernetesDocker.Services;

namespace NAGP2023KubernetesDocker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NAGPSessionController : Controller
    {
        private readonly ISessionService sessionService;
        private readonly ILogger<NAGPSessionController> _logger; 

        public NAGPSessionController(ISessionService sessionService, ILogger<NAGPSessionController> logger)
        {
            this.sessionService = sessionService;
            this._logger = logger;
        }

        [HttpGet(Name = "GetSessionsInfo")]
        public async Task<ActionResult<List<NAGPSessionData>>> GetSessions()
        {
            _logger.LogDebug("Inside Controller");
            var result = sessionService.GetAsync();
            if(result == null || result.Result.Count ==0) 
            {
                return NotFound();
            }
            return Ok(result.Result);
        }
    }
}
