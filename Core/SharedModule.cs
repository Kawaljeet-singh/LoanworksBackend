using LoanworksBackend.Core.Errors;
using LoanworksBackend.Extensions;
using MediatR;

namespace LoanworksBackend.Core;

public class SharedModule : IModule
{
    public IServiceCollection RegisterModules(IServiceCollection services)
    {
        return services;
    }

    public IEndpointRouteBuilder MapEndpoints(IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("/error", (IMediator mediator, HttpContext context) =>
        {
            return mediator.Send<IResult>(new ErrorInput() { Context = context });
        })
        .WithTags("shared");

        return endpoints;
    }
}