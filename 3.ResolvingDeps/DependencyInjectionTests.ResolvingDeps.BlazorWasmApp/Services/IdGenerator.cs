namespace DependencyInjectionTests.ResolvingDeps.BlazorWasmApp.Services;

public class IdGenerator
{
    public Guid NewGuid => Guid.NewGuid();
}