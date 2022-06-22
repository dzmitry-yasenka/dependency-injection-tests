using Jab;

namespace DependencyInjectionTests.Advanced.DependencyInjectionFuture.ConsoleApp;

[ServiceProvider]
[Transient(typeof(IConsoleWriter), typeof(ConsoleWriter))]
public partial class MyServiceProvider
{

}