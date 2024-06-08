
using LoanworksBackend.Modules.Management.Commands.Management;
using LoanworksBackend.Modules.Management.Core.ApplicationTypes;
using LoanworksBackend.Modules.Management.Query.Management;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoanworksBackend.Modules.Management.Endpoint.Management;


public static class InsertApplicationTypesEndpoint
{
    /// <summary>
    /// Assigned type in Application
    /// </summary>
    /// <param name="mediator"></param>
    /// <param name="ApplicationTypesInsert"></param>
    /// <returns></returns>
    [ProducesResponseType(typeof(List<ApplicationTypesInsert>), StatusCodes.Status200OK)]
    public static async Task<IResult> Handle([FromBody] ApplicationTypesInsert ApplicationTypesInsert, IMediator mediator)
    {
        var response = await mediator.Send(new InsertApplicationTypesCommand() { ApplicationTypesInsert = ApplicationTypesInsert });

        if (response == null)
            return Results.NotFound();
        else
            return Results.Ok(response);
    }
}
