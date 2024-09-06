using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fizzbuzz.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ICalculation _calculation;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ICalculation calculation)
        {
            _logger = logger;
            _calculation = calculation;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("{Calculation}/{values}")]
        public string Calculation(string values)
        {
            values = values.Replace("[", "").Replace("]", "").Trim();
            var result1 = _calculation.GetCalculationResults(values);
            return result1;
        }

        [HttpGet("{Calculation}")]
        public string Calculation()
        {
            return "Invalid Terms ";
        }
    }
}
