﻿using DependencyInjectionTests.Scrutor.Scanning.WeatherApi.Logging;
using DependencyInjectionTests.Scrutor.Scanning.WeatherApi.Weather;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionTests.Scrutor.Scanning.WeatherApi.Controllers;


[ApiController]
public class WeatherForecastController : ControllerBase
{
    private readonly IWeatherService _weatherService;
    private readonly ILoggerAdapter<WeatherForecastController> _logger;

    public WeatherForecastController(IWeatherService weatherService,
        ILoggerAdapter<WeatherForecastController> logger)
    {
        _weatherService = weatherService;
        _logger = logger;
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