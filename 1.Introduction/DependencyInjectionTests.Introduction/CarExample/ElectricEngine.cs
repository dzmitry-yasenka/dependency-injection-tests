namespace DependencyInjectionTests.Introduction.CarExample;

public class ElectricEngine : ICarEngine
{
    public void Start()
    {
        Console.WriteLine("Electric car engine starts...");
    }

    public void Stop()
    {
        Console.WriteLine("Electric car engine stops...");
    }
}