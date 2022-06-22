﻿using DependencyInjectionTests.Advanced.MultiFunction.ConsoleApp.Console;
using DependencyInjectionTests.Advanced.MultiFunction.ConsoleApp.Weather;

namespace DependencyInjectionTests.Advanced.MultiFunction.ConsoleApp.Handlers;

[CommandName("weather")]
public class GetCurrentLondonWeatherHandler : IHandler
{
    private readonly IConsoleWriter _consoleWriter;
    private readonly IWeatherService _weatherService;

    public GetCurrentLondonWeatherHandler(IConsoleWriter consoleWriter,
        IWeatherService weatherService)
    {
        _consoleWriter = consoleWriter;
        _weatherService = weatherService;
    }

    public async Task HandleAsync()
    {
        var weather = await _weatherService.GetCurrentWeatherAsync("London");
        _consoleWriter.WriteLine($"The temperature in London is {weather!.Main.Temp}C");
    }
}