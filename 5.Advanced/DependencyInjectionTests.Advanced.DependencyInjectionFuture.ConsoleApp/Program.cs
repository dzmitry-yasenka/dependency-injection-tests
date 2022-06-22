using DependencyInjectionTests.Advanced.DependencyInjectionFuture.ConsoleApp;

var serviceProvider = new MyServiceProvider();

var consoleWriter = serviceProvider.GetService<IConsoleWriter>();

consoleWriter.WriteLine("Hello World from source generator DI!");