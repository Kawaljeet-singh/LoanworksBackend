using LoanworksBackend.Modules.Applications.Core.Collateral_RealEstate;
using LoanworksBackend.Modules.Applications.Query.Collateral_RealEstate;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoanworksBackend.Modules.Applications.Endpoints.Collateral_RealEstate;

public static class GetCollateralRealEstateByAppIDEndPoint
{
    /// <summary>
    /// Returns CollateralRealEstate Details based on given AppId
    /// </summary>
    /// <param name="mediator"></param>
    /// <param name="appId"></param>
    /// <returns></returns>
    [ProducesResponseType(typeof(List<CollateralRealEstate>), StatusCodes.Status200OK)]
    public static async Task<IResult> Handle(int appId, IMediator mediator)
    {
        var response = await mediator.Send(new GetCollateralRealEstateByAppIDQuery() { AppId = appId });

        if (response == null)
            return Results.NotFound();
        else
            return Results.Ok(response);
    }
}

