using DependencyInjectionTests.DeepDive.WeatherApi.Logging;
using DependencyInjectionTests.DeepDive.WeatherApi.Mappers;
using DependencyInjectionTests.DeepDive.WeatherApi.Weather;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHttpClient();

builder.Services.AddWeatherServices();

builder.Services.AddSingleton<IMapper, Mapper>();
builder.Services.AddTransient(typeof(ILoggerAdapter<>), typeof(LoggerAdapter<>));

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