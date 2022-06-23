using DependencyInjectionTests.Scrutor.Scanning.ConsoleApp.Attributes;
using DependencyInjectionTests.Scrutor.Scanning.ConsoleApp.ServiceMarkers;
using Microsoft.Extensions.DependencyInjection;
using Scrutor;

namespace DependencyInjectionTests.Scrutor.Scanning.ConsoleApp.Services;

[Singleton]
[ServiceDescriptor(typeof(IExampleAService), ServiceLifetime.Singleton)]
public class ExampleAService : IExampleAService, ISingletonService
{

}

public interface IExampleAService
{

}