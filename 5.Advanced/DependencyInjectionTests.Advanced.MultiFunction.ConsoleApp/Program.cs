using DependencyInjectionTests.Advanced.MultiFunction.ConsoleApp;
using DependencyInjectionTests.Advanced.MultiFunction.ConsoleApp.Console;
using DependencyInjectionTests.Advanced.MultiFunction.ConsoleApp.Handlers;
using DependencyInjectionTests.Advanced.MultiFunction.ConsoleApp.Time;
using DependencyInjectionTests.Advanced.MultiFunction.ConsoleApp.Weather;
using Microsoft.Extensions.DependencyInjection;


var services = new ServiceCollection();

services.AddSingleton<IConsoleWriter, ConsoleWriter>();
services.AddHttpClient();
services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
services.AddSingleton<IWeatherService, InMemoryWeatherService>();

services.AddCommandHandlers(typeof(Program).Assembly);

services.AddSingleton<Application>();

var serviceProvider = services.BuildServiceProvider();

var application = serviceProvider.GetRequiredService<Application>();
if (args.Length == 0)
{
    args = new[] { "time" };
}

await application.RunAsync(args);