
using LoanworksBackend.Modules.Management.Core.ApplicationTypes;
using LoanworksBackend.Modules.Management.Query.Management;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoanworksBackend.Modules.Management.Endpoint.Management;


public static class GetApplicationTypesEndpoint
{
    /// <summary>
    /// Returns Application Types assigned in application
    /// </summary>
    /// <param name="mediator"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    [ProducesResponseType(typeof(List<ApplicationTypes>), StatusCodes.Status200OK)]
    public static async Task<IResult> Handle(int id, IMediator mediator)
    {
        var response = await mediator.Send(new GetApplicationTypesQuery() { Id = id });

        if (response == null)
            return Results.NotFound();
        else
            return Results.Ok(response);
    }
}
