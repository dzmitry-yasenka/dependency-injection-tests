using DependencyInjectionTests.Fundamentals.Weather.Api.Filters;
using DependencyInjectionTests.Fundamentals.Weather.Api.Model;
using DependencyInjectionTests.Fundamentals.Weather.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionTests.Fundamentals.Weather.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherController : ControllerBase
{
    private readonly IWeatherService _weatherService;
    private readonly ILogger<WeatherController> _logger;
    private readonly IdGenerator _idGenerator;

    public WeatherController(IWeatherService weatherService, ILogger<WeatherController> logger, IdGenerator idGenerator)
    {
        _weatherService = weatherService;
        _logger = logger;
        _idGenerator = idGenerator;
    }

    [HttpGet("{city}")]
    [ServiceFilter(typeof(LifetimeIndicatorFilter))]
    public ActionResult<WeatherResponse> GetWeatherResponse(string city)
    {
        _logger.LogInformation("Endpoint call with id: {Id}", _idGenerator.Id);
        return Ok(_weatherService.GetWeather(city));
    }
}