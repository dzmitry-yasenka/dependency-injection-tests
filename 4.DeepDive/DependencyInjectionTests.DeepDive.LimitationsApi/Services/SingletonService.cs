namespace DependencyInjectionTests.DeepDive.LimitationsApi.Services;

public class SingletonService
{
    public Guid Id { get; } = Guid.NewGuid();
}