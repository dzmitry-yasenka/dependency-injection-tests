using DependencyInjectionTests.Fundamentals.Weather.ConsoleApp.Services;

namespace DependencyInjectionTests.Fundamentals.Weather.ConsoleApp;

public class Application
{
    private readonly IWeatherService _weatherService;

    public Application(IWeatherService weatherService)
    {
        _weatherService = weatherService;
    }

    public async Task RunAsync(string[] args)
    {
        var city = args[0];
        var weather = await _weatherService.GetWeather(city);
        Console.WriteLine(weather);
    }
}