using Elsa.Activities.Workflows.Extensions;
using Elsa.Models;
using Elsa.Services;
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
        private IWorkflowInvoker _workflowInvoker;

        public UserController(
            ILogger<UserController> logger,
            IWorkflowInvoker workflowInvoker)
        {
            _logger = logger;
            _workflowInvoker = workflowInvoker;
        }

        [Route("register")]
        [HttpPost]
        public async Task<IActionResult> UserRegistration(RegistrationModel request)
        {
            _logger.LogInformation("Registering new user...");
            _logger.LogInformation($"Name: {request.Name}");
            _logger.LogInformation($"Email: {request.Email}");

            // Sets the variables that will be passed to the workflow
            var input = new Variables();
            input.SetVariable("RegistrationModel", request);

            // Triggers the workflow execution (same name as registered in the Dashboard)
            await _workflowInvoker.TriggerSignalAsync("RegisterUser", input);
            return StatusCode(StatusCodes.Status200OK);
        }
    }
}
