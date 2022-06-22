namespace DependencyInjectionTests.Advanced.MultiFunction.ConsoleApp.Time;

public interface IDateTimeProvider
{
    public DateTime DateTimeNow { get; }

    public DateTime DateTimeUtcNow { get; }
}