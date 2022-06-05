namespace DependencyInjectionTests.ResolvingDeps.BlazorServerApp.Services;

public class IdGenerator
{
    public Guid NewGuid => Guid.NewGuid();
}