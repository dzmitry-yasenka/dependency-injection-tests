using Grpc.Core;
using DependencyInjectionTests.ResolvingDeps.GrpcService;

namespace DependencyInjectionTests.ResolvingDeps.GrpcService.Services;

public class GreeterService : Greeter.GreeterBase
{
    private readonly ILogger<GreeterService> _logger;

    public GreeterService(ILogger<GreeterService> logger)
    {
        _logger = logger;
    }

    public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
    {
        _logger.LogInformation("DI in the GRPC service");
        return Task.FromResult(new HelloReply
        {
            Message = "Hello " + request.Name
        });
    }
}