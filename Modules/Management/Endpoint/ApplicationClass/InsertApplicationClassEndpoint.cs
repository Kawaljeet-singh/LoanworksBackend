using System.Net;
using LoanworksBackend.Modules.Management.Commands.Management;
using LoanworksBackend.Modules.Management.Core.ApplicationClass;

using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoanworksBackend.Modules.Management.Endpoint.Management;


public static class InsertApplicationClassEndpoint
{
    /// <summary>
    /// Inserts Record in the Application Class
    /// </summary>
    /// <param name="mediator"></param>
    /// <param name="ApplicationClass"></param>
    /// <returns></returns>
    [ProducesResponseType(typeof(List<ApplicationClass>), StatusCodes.Status200OK)]
    public static async Task<IResult> Handle([FromBody]  ApplicationClass ApplicationClass, IMediator mediator)
    {
        var response = await mediator.Send(new InsertApplicationClassCommand(){ApplicationClass = ApplicationClass });

        if (response == null)
            return Results.NotFound();
        else
            return Results.Ok(response);
    }
}
