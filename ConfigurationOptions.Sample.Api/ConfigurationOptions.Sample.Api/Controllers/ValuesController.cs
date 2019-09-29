using System;
using System.Collections.Generic;
using ConfigurationOptions.Sample.Api.Configurations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace ConfigurationOptions.Sample.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IOptions<ValuesConfiguration> _options;

        public ValuesController(IOptions<ValuesConfiguration> options)
        {
            _options = options;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var valuesConfig = _options.Value;
            var result = new List<String>();

            for (int i = 0; i < valuesConfig.ValuesCount; i++)
            {
                result.Add($"{valuesConfig.ValuesPreset}{i}");
            }
            return Ok(result);
        }

        [HttpGet("ping")]
        public ActionResult<String> Ping()
        {
            return Ok("pong");
        }

    }
}
