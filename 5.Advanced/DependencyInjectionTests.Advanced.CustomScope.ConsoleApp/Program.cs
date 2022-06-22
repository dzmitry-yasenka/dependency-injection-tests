// See https://aka.ms/new-console-template for more information

using DependencyInjectionTests.Advanced.CustomScope.ConsoleApp;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

services.AddScoped<ExampleService>();

var serviceProvider = services.BuildServiceProvider();

var serviceScopeFactory = serviceProvider.GetRequiredService<IServiceScopeFactory>();

using (var serviceScope = serviceScopeFactory.CreateScope())
{
    var exampleService = serviceScope.ServiceProvider.GetRequiredService<ExampleService>();
    Console.WriteLine(exampleService.Id);
}

using (var serviceScope = serviceScopeFactory.CreateScope())
{
    var exampleService = serviceScope.ServiceProvider.GetRequiredService<ExampleService>();
    Console.WriteLine(exampleService.Id);
}

using (var serviceScope = serviceScopeFactory.CreateScope())
{
    var exampleService = serviceScope.ServiceProvider.GetRequiredService<ExampleService>();
    Console.WriteLine(exampleService.Id);
}

var exampleService1 = serviceProvider.GetRequiredService<ExampleService>();
Console.WriteLine(exampleService1.Id);

var exampleService2 = serviceProvider.GetRequiredService<ExampleService>();
Console.WriteLine(exampleService2.Id);

var exampleService3 = serviceProvider.GetRequiredService<ExampleService>();
Console.WriteLine(exampleService3.Id);

Console.ReadKey();
