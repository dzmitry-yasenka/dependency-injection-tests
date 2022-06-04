namespace DependencyInjectionTests.Introduction.GreeterExample;

public interface IDateTimeProvider
{
    DateTime Now { get; }
}