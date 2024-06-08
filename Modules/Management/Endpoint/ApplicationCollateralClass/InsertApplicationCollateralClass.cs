using LoanworksBackend.Modules.Management.Commands.Management;
using LoanworksBackend.Modules.Management.Core.ApplicationCollateralClass;

using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoanworksBackend.Modules.Management.Endpoint.Management;

/// <summary>
/// API endpoint that gets all the funds position for management
/// </summary>
public static class InsertApplicationCollateralClass
{
    /// <summary>
    /// Assign Collateral Class in Application Class
    /// </summary>
    /// <param name="mediator"></param>
    /// <param name="applicationCollateralClass"></param>
    
    /// <returns></returns>
    [ProducesResponseType(typeof(List<ApplicationCollateralClassInsert>), StatusCodes.Status200OK)]
    public static async Task<IResult> Handle([FromBody] ApplicationCollateralClassInsert applicationCollateralClass, IMediator mediator)
    {
        var response = await mediator.Send(new InsertApplicationCollateralClassCommand(){ ApplicationCollateralClass = applicationCollateralClass});
        
        if (response == null)
            return Results.NotFound();
        else
            return Results.Ok(response);
    }
}
