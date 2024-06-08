using LoanworksBackend.Modules.Management.Core.ApplicationCollateralClass;
using LoanworksBackend.Modules.Management.Query.Management;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoanworksBackend.Modules.Management.Endpoint.Management;

/// <summary>
/// API endpoint that gets all the funds position for management
/// </summary>
public static class GetApplicationCollateralClass
{
    /// <summary>
    /// Returns Collateral Class assigned in Application Class
    /// </summary>
    /// <param name="id"></param>
    /// <param name="mediator"></param>
    /// <returns></returns>
    [ProducesResponseType(typeof(List<ApplicationCollateralGet>), StatusCodes.Status200OK)]
    public static async Task<IResult> Handle(int id, IMediator mediator)
    {
        var response = await mediator.Send(new GetApplicationCollateralClassQuery(){Id = id});

        if (response == null)
            return Results.NotFound();
        else
            return Results.Ok(response);
    }
}
