using DependencyInjectionTests.Fundamentals.Weather.Api.Filters;
using DependencyInjectionTests.Fundamentals.Weather.Api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IdGenerator>();
builder.Services.AddScoped<LifetimeIndicatorFilter>();
builder.Services.AddTransient<IWeatherService, WeatherService>();

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();