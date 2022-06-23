using DependencyInjectionTests.Scrutor.Scanning.ConsoleApp.Attributes;
using DependencyInjectionTests.Scrutor.Scanning.ConsoleApp.ServiceMarkers;
using Microsoft.Extensions.DependencyInjection;
using Scrutor;

namespace DependencyInjectionTests.Scrutor.Scanning.ConsoleApp.Services;

[Transient]
[ServiceDescriptor(typeof(IExampleCService), ServiceLifetime.Transient)]
public class ExampleCService : IExampleCService, ITransientService
{

}

public interface IExampleCService
{

}