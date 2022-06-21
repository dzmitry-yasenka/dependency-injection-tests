namespace DependencyInjectionTests.DeepDive.WeatherApi.Weather;

public interface IWeatherService
{
    Task<WeatherModel?> GetCurrentWeatherAsync(string city);
}