using LoanworksBackend.Modules.Applications.Core.ApplicationLiabilities;
using LoanworksBackend.Modules.Applications.Query.ApplicationLiabilities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoanworksBackend.Modules.Applications.Endpoints.ApplicationLiabilities;

public static class GetAppLiabilitiesByIDEndPoint
{
    /// <summary>
    ///  Returns AppLiabilities Details based on given AppLiabilities By Id
    /// </summary>
    /// <param name="mediator"></param>
    /// <param name="liabilityId"></param>
    /// <returns></returns>  
    [ProducesResponseType(typeof(ApplicationLiability), StatusCodes.Status200OK)]
    public static async Task<IResult> Handle(int liabilityId, IMediator mediator)
    {
        var response = await mediator.Send(new GetAppLiabilitiesByIDQuery() { LiabilityId = liabilityId });

        if (response == null || response.Count() == 0)
            return Results.NotFound();
        else
            return Results.Ok(response.FirstOrDefault());
    }
}

