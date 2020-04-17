using Elsa_Workflow.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Elsa_Workflow.Controllers
{
    [ApiController]
    [Route("users")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [Route("register")]
        [HttpPost]
        public async Task<IActionResult> UserRegistration(RegistrationModel request)
        {
            // TODO
            _logger.LogInformation("Registering new user...");
            return StatusCode(StatusCodes.Status200OK);
        }

        [Route("activate/{userId}")]
        [HttpPost]
        public async Task<IActionResult> ActivateUser(string userId)
        {
            // TODO
            _logger.LogInformation($"Activating user {userId}...");
            return StatusCode(StatusCodes.Status200OK);
        }
    }
}
