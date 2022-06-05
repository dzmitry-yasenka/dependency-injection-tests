namespace DependencyInjectionTests.ResolvingDeps.Mvc.Services;

public class IdGenerator
{
    public Guid NewGuid => Guid.NewGuid();
}