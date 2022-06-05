namespace DependencyInjectionTests.ResolvingDeps.ConsoleApp.Weather;

public interface IWeatherService
{
    public Task<WeatherResponse> GetWeather(string city);
}