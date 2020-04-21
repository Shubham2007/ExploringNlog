using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ExploringNlog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ILogger<ValuesController> _logger;

        public ValuesController(ILogger<ValuesController> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            _logger.Log(LogLevel.Critical, "Critical logging");
            _logger.LogError("Logging Error");
            _logger.LogInformation("Logging Info");
            _logger.LogTrace("Logging Trace");
            _logger.LogDebug("Logging Debug");
            _logger.LogWarning("Logging Warning");
            _logger.LogCritical("Logging Critical");

            return new string[] { "value1", "value2" };
        }

    }
}
