namespace Vax;

public class ServiceCollection : List<ServiceDescriptor>
{
    public ServiceCollection AddService(ServiceDescriptor serviceDescriptor)
    { 
        Add(serviceDescriptor);
        return this;
    }

    public ServiceCollection AddSingleton<TService>()
        where TService : class
    {
        Add(ServiceDescriptor.Singleton<TService, TService>());
        return this;
    }
    
    public ServiceCollection AddSingleton<TService>(Func<ServiceProvider, TService> factory)
        where TService : class
    {
        Add(ServiceDescriptor.Singleton<TService>(factory));
        return this;
    }
    
    public ServiceCollection AddSingleton(object implementationInstance)
    {
        Add(ServiceDescriptor.Singleton(implementationInstance));
        return this;
    }
    
    public ServiceCollection AddSingleton<TService, TImplementation>()
        where TService : class
        where TImplementation : class, TService
    {
        Add(ServiceDescriptor.Singleton<TService, TImplementation>());
        return this;
    }

    public ServiceCollection AddTransient<TService>()
        where TService : class
    {
        Add(ServiceDescriptor.Transient<TService, TService>());
        return this;
    }
    
    public ServiceCollection AddTransient<TService>(Func<ServiceProvider, TService> factory)
        where TService : class
    {
        Add(ServiceDescriptor.Transient<TService>(factory));
        return this;
    }
    
    public ServiceCollection AddTransient(object implementationInstance)
    {
        Add(ServiceDescriptor.Transient(implementationInstance));
        return this;
    }
    
    public ServiceCollection AddTransient<TService, TImplementation>()
        where TService : class
        where TImplementation : class, TService
    {
        Add(ServiceDescriptor.Transient<TService, TImplementation>());
        return this;
    }

    public ServiceProvider BuildServiceProvider()
    {
        return new ServiceProvider(this);
    }
}