namespace DependencyInjectionTests.DeepDive.WeatherApi.Logging;

public interface ILoggerAdapter<TType>
{
    void LogInformation(string template, params object[] args);
}
