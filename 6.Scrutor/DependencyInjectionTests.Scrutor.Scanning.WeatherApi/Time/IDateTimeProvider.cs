namespace DependencyInjectionTests.Scrutor.Scanning.WeatherApi.Time;

public interface IDateTimeProvider
{
    public DateTime DateTimeNow { get; }

    public DateTime DateTimeUtcNow { get; }
}