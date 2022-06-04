namespace DependencyInjectionTests.Introduction.CarExample;

public class PetrolEngine : ICarEngine
{
    public void Start()
    {
        Console.WriteLine("Petrol car engine starts...");
    }

    public void Stop()
    {
        Console.WriteLine("Petrol car engine stops...");
    }
}