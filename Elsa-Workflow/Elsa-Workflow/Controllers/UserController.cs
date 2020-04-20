using Elsa.Activities.Workflows.Extensions;
using Elsa.Models;
using Elsa.Services;
using Elsa_Workflow.Business;
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
        private IUserBusiness _userBusiness;

        public UserController(
            ILogger<UserController> logger,
            IUserBusiness userBusiness)
        {
            _logger = logger;
            _userBusiness = userBusiness;
        }

        [Route("register")]
        [HttpPost]
        public async Task<IActionResult> UserRegistration(RegistrationModel request)
        {
            _logger.LogInformation("Registering new user...");
            _logger.LogInformation($"name: {request.Name}");
            _logger.LogInformation($"email: {request.Email}");

            // Calls business that triggers workflow start signal execution
            await _userBusiness.UserRegistration(request);

            return StatusCode(StatusCodes.Status200OK);
        }
    }
}
