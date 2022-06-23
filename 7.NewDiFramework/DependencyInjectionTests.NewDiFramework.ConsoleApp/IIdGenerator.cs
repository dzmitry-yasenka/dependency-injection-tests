namespace DependencyInjectionTests.NewDiFramework.ConsoleApp;

public interface IIdGenerator
{
    public Guid Id { get; }

    void PrintId();
}