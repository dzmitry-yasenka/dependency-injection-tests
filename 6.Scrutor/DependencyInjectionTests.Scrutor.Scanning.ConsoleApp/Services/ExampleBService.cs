using DependencyInjectionTests.Scrutor.Scanning.ConsoleApp.Attributes;
using DependencyInjectionTests.Scrutor.Scanning.ConsoleApp.ServiceMarkers;
using Microsoft.Extensions.DependencyInjection;
using Scrutor;

namespace DependencyInjectionTests.Scrutor.Scanning.ConsoleApp.Services;

[Scoped]
[ServiceDescriptor(typeof(IExampleBService), ServiceLifetime.Scoped)]
public class ExampleBService : IExampleBService, IScopedService
{

}

public interface IExampleBService
{

}