using DependencyInjectionTests.Fundamentals.Weather.Api.Model;

namespace DependencyInjectionTests.Fundamentals.Weather.Api.Services;

public class WeatherService : IWeatherService
{
    public Task<WeatherResponse> GetWeather(string city)
    {
        return Task.FromResult(new WeatherResponse(city, 10, "degC"));
    }
}