using LoanworksBackend.Modules.Applications.Commands.Collateral_RealEstate;
using LoanworksBackend.Modules.Applications.Core.Collateral_RealEstate;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoanworksBackend.Modules.Applications.Endpoints.Collateral_RealEstate;

public class InsertCollateralRealEstateEndPoint
{
    /// <summary>
    /// Insert Record in Collateral RealEstate
    /// </summary>
    /// <param name="mediator"></param>
    /// <param name="InsertCollateralRealEstate"></param>
    /// <returns></returns>
    [ProducesResponseType(typeof(List<InsertCollateralRealEstate>), StatusCodes.Status200OK)]
    public static async Task<IResult> Handle([FromBody] InsertCollateralRealEstate InsertCollateralRealEstate, IMediator mediator)
    {
        var response = await mediator.Send(new InsertCollateralRealEstateCommand() { InsertCollateralRealEstate = InsertCollateralRealEstate });

        if (response == null)
            return Results.NotFound();
        else
            return Results.Ok(response);
    }
}

