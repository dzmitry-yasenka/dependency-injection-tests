namespace DependencyInjectionTests.Fundamentals.Weather.Api.Model;

public record WeatherResponse(string city, double Temperature, string TemperatureUoM);