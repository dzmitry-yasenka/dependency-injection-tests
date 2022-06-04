namespace DependencyInjectionTests.Introduction.CarExample;

public class Car
{
    private readonly ICarEngine _carEngine;

    public Car(ICarEngine carEngine)
    {
        _carEngine = carEngine;
    }

    public void Start()
    {
        _carEngine.Start();
    }

    public void Stop()
    {
        _carEngine.Stop();
    }
}