using LoanworksBackend.Modules.Applications.Commands.Collateral_RealEstate;
using LoanworksBackend.Modules.Applications.Core.Collateral_RealEstate;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoanworksBackend.Modules.Applications.Endpoints.Collateral_RealEstate;

public static class DeleteCollateralRealEstateEndPoint
{
    /// <summary>
    /// Delete CollateralRealEstate By Id 
    /// </summary>
    /// <param name="mediator"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    [ProducesResponseType(typeof(List<CollateralRealEstate>), StatusCodes.Status200OK)]
    public static async Task<IResult> Handle(int id, IMediator mediator)
    {
        var response = await mediator.Send(new DeleteCollateralRealEstateCommand() { Id = id });

        if (response == null)
            return Results.NotFound();
        else
            return Results.Ok(response);
    }
}

