namespace DependencyInjectionTests.DeepDive.WeatherApi.Contracts;

public class WeatherResponse
{
    public string City { get; init; }

    public int Timezone { get; init; }

    public string Country { get; init; }

    public double Temperature { get; init; }

    public double FeelsLike { get; init; }

    public int Humidity { get; init; }
}