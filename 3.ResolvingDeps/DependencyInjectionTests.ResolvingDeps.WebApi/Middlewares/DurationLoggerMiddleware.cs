using System.Diagnostics;

namespace DependencyInjectionTests.ResolvingDeps.WebApi.Middlewares;

public class DurationLoggerMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<DurationLoggerMiddleware> _logger;

    public DurationLoggerMiddleware(RequestDelegate next, ILogger<DurationLoggerMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        var stopWatch = Stopwatch.StartNew();
        try
        {
            await _next(context);
        }
        finally
        {
            _logger.LogInformation("Request completed in {ElapsedMilliseconds} ms", stopWatch.ElapsedMilliseconds);
        }
    }
}