namespace DependencyInjectionTests.DeepDive.LimitationsApi.Services;

internal sealed class ServiceB
{
    private readonly ServiceA _serviceA;

    public ServiceB(ServiceA serviceA)
    {
        _serviceA = serviceA;
    }
}