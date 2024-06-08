using LoanworksBackend.Modules.Management.Core.ApplicationClass;

using LoanworksBackend.Modules.Management.Query.Management;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoanworksBackend.Modules.Management.Endpoint.Management;

/// <summary>
/// API endpoint that gets all the funds position for management
/// </summary>
public static class ListAllApplicationClassEndpoint
{
    /// <summary>
    /// Returns the list of Application Class
    /// </summary>
    /// <param name="mediator"></param>
    /// <returns></returns>
    [ProducesResponseType(typeof(List<ApplicationClass>), StatusCodes.Status200OK)]
    public static async Task<IResult> Handle(IMediator mediator)
    {
        //var response = await mediator.Send(new ListAllApplicationClassQuery());

        //if (response == null)
        //    return Results.NotFound();
       // else
            return Results.Ok("hello");
    }
}
