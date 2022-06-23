namespace DependencyInjectionTests.Scrutor.Scanning.WeatherApi.Weather;

public interface IWeatherService
{
    Task<WeatherResponse?> GetCurrentWeatherAsync(string city);
}