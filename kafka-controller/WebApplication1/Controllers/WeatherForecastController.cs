using KafkaProducer.Appplication;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
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
        private readonly IKafkaService _kafkaService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IKafkaService kafkaService)
        {
            _logger = logger;
            _kafkaService = kafkaService;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<IActionResult> Get()
        {
            var test = new WeatherForecast();
            await _kafkaService.PushKafka(new KafkaProducer.Appplication.DTOs.RequestDto() {
                Data = test
            });
            return Ok(1);
        }
    }
}
