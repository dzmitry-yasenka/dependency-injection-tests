using DependencyInjectionTests.Scrutor.Scanning.WeatherApi.Logging;
using DependencyInjectionTests.Scrutor.Scanning.WeatherApi.Time;
using DependencyInjectionTests.Scrutor.Scanning.WeatherApi.Weather;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHttpClient();
builder.Services.AddTransient<IWeatherService, InMemoryWeatherService>();
builder.Services.Decorate<IWeatherService, LoggedWeatherService>();

builder.Services.AddSingleton(typeof(ILoggerAdapter<>), typeof(LoggerAdapter<>));
builder.Services.AddSingleton<IDateTimeProvider, DateTimeProvider>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();