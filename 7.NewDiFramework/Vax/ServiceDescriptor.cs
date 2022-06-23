namespace Vax;

public class ServiceDescriptor
{
    public Type ServiceType { get; private init; } = default!;

    public Type ImplementationType { get; private init; } = default!;

    public ServiceLifetime Lifetime { get; private init; }
    
    public object? ImplementationInstance { get; private init; }
    
    public Func<ServiceProvider, object>? ImplementationFactory { get; private init; }

    public static ServiceDescriptor Singleton<TService, TImplementation>() where TService : class where TImplementation : class, TService
    {
        return new ServiceDescriptor
        {
            ServiceType = typeof(TService),
            ImplementationType = typeof(TImplementation),
            Lifetime = ServiceLifetime.Singleton
        };
    }
    
    public static ServiceDescriptor Singleton<TService>(Func<ServiceProvider, object> implementationFactory)
    {
        return new ServiceDescriptor
        {
            ServiceType = typeof(TService),
            ImplementationType = typeof(TService),
            Lifetime = ServiceLifetime.Singleton,
            ImplementationFactory = implementationFactory
        };
    }
    
    public static ServiceDescriptor Singleton(object implementationInstance)
    {
        var implementationType = implementationInstance.GetType();
        return new ServiceDescriptor
        {
            ServiceType = implementationType,
            ImplementationType = implementationType,
            Lifetime = ServiceLifetime.Singleton,
            ImplementationInstance = implementationInstance
        };
    }

    public static ServiceDescriptor Transient<TService>(Func<ServiceProvider, object> implementationFactory)
    {
        return new ServiceDescriptor
        {
            ServiceType = typeof(TService),
            ImplementationType = typeof(TService),
            Lifetime = ServiceLifetime.Transient,
            ImplementationFactory = implementationFactory
        };
    }
    
    public static ServiceDescriptor Transient(object implementationInstance)
    {
        var implementationType = implementationInstance.GetType();
        return new ServiceDescriptor
        {
            ServiceType = implementationType,
            ImplementationType = implementationType,
            Lifetime = ServiceLifetime.Transient,
            ImplementationInstance = implementationInstance
        };
    }
    
    public static ServiceDescriptor Transient<TService, TImplementation>() where TService : class where TImplementation : class, TService
    {
        return new ServiceDescriptor
        {
            ServiceType = typeof(TService),
            ImplementationType = typeof(TImplementation),
            Lifetime = ServiceLifetime.Transient
        };
    }
}