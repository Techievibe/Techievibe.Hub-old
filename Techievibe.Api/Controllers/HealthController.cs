using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;


namespace Techievibe.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        // GET: api/<HealthController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("The Api is running in " + Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT"));
        }
    }
}
