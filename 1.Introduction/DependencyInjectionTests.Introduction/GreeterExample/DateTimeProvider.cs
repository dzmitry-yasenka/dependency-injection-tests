namespace DependencyInjectionTests.Introduction.GreeterExample;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime Now => DateTime.Now;
}