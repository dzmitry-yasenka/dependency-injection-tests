using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DependencyInjectionTests.ResolvingDeps.WebApi.Filters;

public class DurationLoggerFilter : IAsyncActionFilter
{
    private readonly ILogger<DurationLoggerFilter> _logger;

    public DurationLoggerFilter(ILogger<DurationLoggerFilter> logger)
    {
        _logger = logger;
    }

    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        var stopWatch = Stopwatch.StartNew();
        try
        {
            await next();
        }
        finally
        {
            _logger.LogInformation("Request completed in {ElapsedMilliseconds}", stopWatch.ElapsedMilliseconds);
        }
    }
}