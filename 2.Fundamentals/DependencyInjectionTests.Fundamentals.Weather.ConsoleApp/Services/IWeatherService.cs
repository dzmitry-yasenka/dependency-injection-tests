namespace DependencyInjectionTests.Fundamentals.Weather.ConsoleApp.Services;

public interface IWeatherService
{
    public Task<WeatherResponse> GetWeather(string city);
}