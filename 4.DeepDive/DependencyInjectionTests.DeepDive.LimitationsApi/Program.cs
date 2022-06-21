using DependencyInjectionTests.DeepDive.LimitationsApi.Services;

var builder = WebApplication.CreateBuilder(args);

// circular dependencies
//builder.Services.AddTransient<ServiceA>();
//builder.Services.AddTransient<ServiceB>();

builder.Services.AddSingleton<SingletonService>();
builder.Services.AddScoped<ScopedService>();
builder.Services.AddTransient<TransientService>();

var app = builder.Build();

app.MapGet("lifetime",
    (SingletonService singletonService, ScopedService scopedService, TransientService transientService) =>
    {
        var ids = new
        {
            SingletonId = singletonService.Id,
            ScopedId = scopedService.Id,
            TrainsientId = transientService.Id
        };
        
        return Results.Ok(ids);
    });

app.Run();