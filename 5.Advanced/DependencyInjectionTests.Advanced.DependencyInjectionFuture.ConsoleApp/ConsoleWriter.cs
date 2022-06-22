namespace DependencyInjectionTests.Advanced.DependencyInjectionFuture.ConsoleApp;

public class ConsoleWriter : IConsoleWriter
{
    public void WriteLine(string text)
    {
        Console.WriteLine(text);
    }
}