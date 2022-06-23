namespace Vax;

public class ServiceProvider
{
    private readonly Dictionary<Type, Func<object>> _transientsTypes = new();
    private readonly Dictionary<Type, Lazy<object>> _singletonTypes = new();

    internal ServiceProvider(ServiceCollection serviceCollection)
    {
        GenerateServices(serviceCollection);
    }

    public T? GetService<T>()
    {
        return (T?)GetService(typeof(T));
    }

    public object? GetService(Type serviceType)
    {
        var service = _singletonTypes.GetValueOrDefault(serviceType);
        
        if (service != null)
        {
            return service.Value;
        }
        
        var transientService = _transientsTypes.GetValueOrDefault(serviceType);
        return transientService?.Invoke();
    }

    private void GenerateServices(ServiceCollection serviceCollection)
    {
        foreach (var serviceDescriptor in serviceCollection)
        {
            switch (serviceDescriptor.Lifetime)
            {
                case ServiceLifetime.Singleton:
                    if (serviceDescriptor.ImplementationInstance is not null)
                    {
                        _singletonTypes[serviceDescriptor.ServiceType] = new Lazy<object>(
                            () => serviceDescriptor.ImplementationInstance);
                        continue;
                    }
                    if (serviceDescriptor.ImplementationFactory is not null)
                    {
                        _singletonTypes[serviceDescriptor.ServiceType] = new Lazy<object>(
                            () => serviceDescriptor.ImplementationFactory(this));
                        continue;
                    }
                    _singletonTypes[serviceDescriptor.ServiceType] = new Lazy<object>(() =>
                        Activator.CreateInstance(serviceDescriptor.ImplementationType,
                            GetConstructorParameters(serviceDescriptor))!);
                    continue;
                
                case ServiceLifetime.Transient:
                    if (serviceDescriptor.ImplementationFactory is not null)
                    {
                        _transientsTypes[serviceDescriptor.ServiceType] =
                            () => serviceDescriptor.ImplementationFactory(this);
                        continue;
                    }

                    _transientsTypes[serviceDescriptor.ServiceType] = () =>
                        Activator.CreateInstance(serviceDescriptor.ImplementationType,
                            GetConstructorParameters(serviceDescriptor))!;
                    continue;
            }
        }
    }
    
    private object?[] GetConstructorParameters(ServiceDescriptor serviceDescriptor)
    {
        var constructorInfo = serviceDescriptor.ImplementationType.GetConstructors().First();
        var constructorParameters = constructorInfo.GetParameters().Select(x => GetService(x.ParameterType)).ToArray();
        return constructorParameters;
    }
}