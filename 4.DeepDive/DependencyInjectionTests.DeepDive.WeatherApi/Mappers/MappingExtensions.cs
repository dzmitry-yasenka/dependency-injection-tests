﻿using DependencyInjectionTests.DeepDive.WeatherApi.Contracts;
using DependencyInjectionTests.DeepDive.WeatherApi.Weather;

namespace DependencyInjectionTests.DeepDive.WeatherApi.Mappers;

public static class MappingExtensions
{
    public static WeatherResponse MapToWeatherResponse(this WeatherModel weather)
    {
        return new WeatherResponse
        {
            City = weather.Name,
            Country = weather.Sys.Country,
            FeelsLike = weather.Main.FeelsLike,
            Humidity = weather.Main.Humidity,
            Temperature = weather.Main.Temp,
            Timezone = weather.Timezone
        };
    }
}