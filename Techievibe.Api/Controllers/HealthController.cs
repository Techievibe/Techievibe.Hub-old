using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using Techievibe.Logging.Core;

namespace Techievibe.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        private ILogger<HealthController> _logger;
        private ISumoLogHelper _logHelper;

        public HealthController(ILogger<HealthController> logger, ISumoLogHelper logHelper)
        {
            _logger = logger;
            _logHelper = logHelper;
        }

        // GET: api/<HealthController>
        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInformation(_logHelper.GetFormattedInformationMessage("Health End Point data logged."));
            _logger.LogDebug(_logHelper.GetFormattedDebugMessage("Health End Point data logged."));
            _logger.LogError(_logHelper.GetFormattedErrorMessage("Health End Point data logged."));
            _logger.LogWarning(_logHelper.GetFormattedWarningMessage("Health End Point data logged."));

            return Ok("The Api is running in " + Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT"));
        }
    }
}
