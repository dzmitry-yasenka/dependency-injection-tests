namespace DependencyInjectionTests.ResolvingDeps.WebApp.Services;

public class IdGenerator
{
    public Guid NewGuid => Guid.NewGuid();
}