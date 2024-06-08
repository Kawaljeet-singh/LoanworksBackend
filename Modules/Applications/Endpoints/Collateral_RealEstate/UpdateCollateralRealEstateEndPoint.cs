using LoanworksBackend.Modules.Applications.Commands.Collateral_RealEstate;
using LoanworksBackend.Modules.Applications.Core.Collateral_RealEstate;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoanworksBackend.Modules.Applications.Endpoints.Collateral_RealEstate;

public static class UpdateCollateralRealEstateEndPoint
{
    /// <summary>
    /// Update Record in Collateral RealEstate
    /// </summary>
    /// <param name="mediator"></param>
    /// <param name="UpdateCollateralRealEstate"></param>
    /// <returns></returns>
    [ProducesResponseType(typeof(List<UpdateCollateralRealEstate>), StatusCodes.Status200OK)]
    public static async Task<IResult> Handle([FromBody] UpdateCollateralRealEstate UpdateCollateralRealEstate, IMediator mediator)
    {
        var response = await mediator.Send(new UpdateCollateralRealEstateCommand() { UpdateCollateralRealEstate = UpdateCollateralRealEstate });

        if (response == null)
            return Results.NotFound();
        else
            return Results.Ok(response);
    }
}

