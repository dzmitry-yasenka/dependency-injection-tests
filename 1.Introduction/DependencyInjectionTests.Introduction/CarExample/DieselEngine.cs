namespace DependencyInjectionTests.Introduction.CarExample;

public class DieselEngine : ICarEngine
{
    public void Start()
    {
        Console.WriteLine("Diesel car engine starts...");
    }

    public void Stop()
    {
        Console.WriteLine("Diesel car engine stops...");
    }
}