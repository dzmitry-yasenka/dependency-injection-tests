using DependencyInjectionTests.ResolvingDeps.ConsoleApp;
using DependencyInjectionTests.ResolvingDeps.ConsoleApp.Weather;
using Microsoft.Extensions.DependencyInjection;

if (args.Length == 0)
{
    args = new string[1];
    args[0] = "London";
}

var serviceCollection = new ServiceCollection();
serviceCollection.AddSingleton<IWeatherService, WeatherService>();
serviceCollection.AddSingleton<Application>();

var serviceProvider = serviceCollection.BuildServiceProvider();
var application = serviceProvider.GetRequiredService<Application>();

await application.RunAsync(args);