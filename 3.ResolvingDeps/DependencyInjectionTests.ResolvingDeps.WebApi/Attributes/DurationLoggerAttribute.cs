using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DependencyInjectionTests.ResolvingDeps.WebApi.Attributes;

public class DurationLoggerAttribute : Attribute, IAsyncActionFilter
{
    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        var stopWatch = Stopwatch.StartNew();
        try
        {
            await next();
        }
        finally
        {
            var serviceProvider = context.HttpContext.RequestServices;
            var logger = serviceProvider.GetRequiredService<ILogger<DurationLoggerAttribute>>();
            logger.LogInformation("Request completed in {ElapsedMilliseconds} ms", stopWatch.ElapsedMilliseconds);
        }
    }
}