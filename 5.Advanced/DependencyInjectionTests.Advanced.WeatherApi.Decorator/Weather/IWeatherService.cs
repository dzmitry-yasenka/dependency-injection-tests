namespace DependencyInjectionTests.Advanced.WeatherApi.Decorator.Weather;

public interface IWeatherService
{
    Task<WeatherResponse?> GetCurrentWeatherAsync(string city);
}