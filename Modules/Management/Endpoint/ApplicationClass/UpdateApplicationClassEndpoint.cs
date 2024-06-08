using LoanworksBackend.Modules.Management.Commands.Management;
using LoanworksBackend.Modules.Management.Core.ApplicationClass;

using LoanworksBackend.Modules.Management.Query.Management;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoanworksBackend.Modules.Management.Endpoint.Management;

/// <summary>
///
/// </summary>
public static class UpdateApplicationClassEndpoint
{
    /// <summary>
    /// Updates Application Class
    /// </summary>
    /// <param name="ApplicationClass"></param>
    /// <param name="mediator"></param>
    /// <returns></returns>
    [ProducesResponseType(typeof(List<ApplicationClass>), StatusCodes.Status200OK)]
    public static async Task<IResult> Handle([FromBody] ApplicationClass ApplicationClass, IMediator mediator)
    {
        var response = await mediator.Send(new UpdateApplicationClassCommand(){ ApplicationClass = ApplicationClass});

        if (response == null)
            return Results.NotFound();
        else
            return Results.Ok(response);
    }
}
