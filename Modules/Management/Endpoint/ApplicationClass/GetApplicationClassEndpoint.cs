using LoanworksBackend.Modules.Management.Core.ApplicationClass;

using LoanworksBackend.Modules.Management.Query.Management;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoanworksBackend.Modules.Management.Endpoint.Management;


public static class GetApplicationClassEndpoint
{
    /// <summary>
    /// Returns Application Class
    /// </summary>
    /// <param name="mediator"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    [ProducesResponseType(typeof(List<ApplicationClass>), StatusCodes.Status200OK)]
    public static async Task<IResult> Handle(int id, IMediator mediator)
    {
        var response = await mediator.Send(new GetApplicationClassQuery() { id = id });

        if (response == null)
            return Results.NotFound();
        else
            return Results.Ok(response);
    }
}
