using DependencyInjectionTests.Fundamentals.Weather.Api.Model;

namespace DependencyInjectionTests.Fundamentals.Weather.Api.Services;

public interface IWeatherService
{
    public Task<WeatherResponse> GetWeather(string city);
}