using DependencyInjectionTests.Advanced.WeatherApi.Decorator.Weather;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionTests.Advanced.WeatherApi.Decorator.Controllers;

[ApiController]
public class WeatherForecastController : ControllerBase
{
    private readonly IWeatherService _weatherService;

    public WeatherForecastController(IWeatherService weatherService)
    {
        _weatherService = weatherService;
    }

    [HttpGet("weather/{city}")]
    public async Task<IActionResult> GetCurrentWeather([FromRoute] string city)
    {
        var weather = await _weatherService.GetCurrentWeatherAsync(city);
        if (weather == null)
        {
            return NotFound();
        }

        return Ok(weather);
    }
}