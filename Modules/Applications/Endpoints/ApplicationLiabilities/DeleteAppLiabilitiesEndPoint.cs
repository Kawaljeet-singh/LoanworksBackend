using LoanworksBackend.Modules.Applications.Commands.ApplicationLiabilities;
using LoanworksBackend.Modules.Applications.Core.ApplicationLiabilities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoanworksBackend.Modules.Applications.Endpoints.ApplicationLiabilities;

public static class DeleteAppLiabilitiesEndPoint
{
    /// <summary>
    /// Delete AppLiabilities By LiabilityId 
    /// </summary>
    /// <param name="mediator"></param>
    /// <param name="liabilityId"></param>
    /// <returns></returns>
    [ProducesResponseType(typeof(ApplicationLiability), StatusCodes.Status200OK)]
    public static async Task<IResult> Handle(int liabilityId, IMediator mediator)
    {
        var response = await mediator.Send(new DeleteAppLiabilitiesCommand() { LiabilityId = liabilityId });
     
        if (response == 0)
            return Results.NotFound();
        else
            return Results.Ok(response);
    }
}

