namespace DependencyInjectionTests.DeepDive.LimitationsApi.Services;

internal sealed class ServiceA
{
    private readonly ServiceB _serviceB;

    public ServiceA(ServiceB serviceB)
    {
        _serviceB = serviceB;
    }
}