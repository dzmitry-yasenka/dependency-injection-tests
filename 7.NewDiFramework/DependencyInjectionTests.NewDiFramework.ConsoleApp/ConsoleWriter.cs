namespace DependencyInjectionTests.NewDiFramework.ConsoleApp;

public class ConsoleWriter : IConsoleWriter
{
    private readonly Guid _consoleWriterId = Guid.NewGuid();
    
    public void WriteLine(string text)
    {
        Console.WriteLine($"ConsoleWriter {_consoleWriterId} says: {text}");
    }
}