using LoanworksBackend.Modules.Management.Commands.Management;
using LoanworksBackend.Modules.Management.Core.ApplicationClass;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoanworksBackend.Modules.Management.Endpoint.Management;


public static class DeleteApplicationClassEndpoint
{
    /// <summary>
    /// Deletes Record in the Application Class
    /// </summary>
    /// <param name="mediator"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    [ProducesResponseType(typeof(List<ApplicationClass>), StatusCodes.Status200OK)]
    public static async Task<IResult> Handle(int id, IMediator mediator)
    {
        var response = await mediator.Send(new DeleteApplicationClassCommand() { Id = id });

        if (response == null)
            return Results.NotFound();
        else
            return Results.Ok(response);
    }
}
