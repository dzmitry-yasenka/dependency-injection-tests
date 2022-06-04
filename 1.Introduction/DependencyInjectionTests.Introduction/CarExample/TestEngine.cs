namespace DependencyInjectionTests.Introduction.CarExample;

public class TestEngine : ICarEngine
{
    public void Start()
    {
        Console.WriteLine("Do nothing");
    }

    public void Stop()
    {
        Console.WriteLine("Do nothing");
    }
}