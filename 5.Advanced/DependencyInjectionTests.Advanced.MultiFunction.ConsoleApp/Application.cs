using DependencyInjectionTests.Advanced.MultiFunction.ConsoleApp.Console;
using DependencyInjectionTests.Advanced.MultiFunction.ConsoleApp.Handlers;

namespace DependencyInjectionTests.Advanced.MultiFunction.ConsoleApp;

public class Application
{
    private readonly IConsoleWriter _consoleWriter;
    private readonly HandlerOrchestrator _handlerOrchestrator;

    public Application(IConsoleWriter consoleWriter, HandlerOrchestrator handlerOrchestrator)
    {
        _consoleWriter = consoleWriter;
        _handlerOrchestrator = handlerOrchestrator;
    }

    public async Task RunAsync(string[] args)
    {
        var command = args[0];

        var handler = _handlerOrchestrator.GetHandlerForCommandName(command);
        if (handler == null)
        {
            _consoleWriter.WriteLine($"No handler found for command name {command}");
            return;
        }
        await handler.HandleAsync();
    }
}