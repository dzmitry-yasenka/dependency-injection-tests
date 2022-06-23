using DependencyInjectionTests.NewDiFramework.ConsoleApp;
using Vax;

var services = new ServiceCollection();

//services.AddSingleton<IConsoleWriter, ConsoleWriter>();
//services.AddTransient<IIdGenerator, IdGenerator>();

//services.AddSingleton<ConsoleWriter>();
services.AddTransient(new ConsoleWriter());

services.AddTransient<IIdGenerator>(provider => new IdGenerator(provider.GetService<ConsoleWriter>()!));

var serviceProvider = services.BuildServiceProvider();

var service1 = serviceProvider.GetService<IIdGenerator>();
var service2 = serviceProvider.GetService<IIdGenerator>();

service1.PrintId();
service2.PrintId();

Console.WriteLine("Hello, World!");
Console.ReadKey();