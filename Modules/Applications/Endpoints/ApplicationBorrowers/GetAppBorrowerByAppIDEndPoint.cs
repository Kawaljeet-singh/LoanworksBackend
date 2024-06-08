using LoanworksBackend.Modules.Applications.Core.ApplicationBorrowers;
using LoanworksBackend.Modules.Applications.Query.ApplicationBorrowers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoanworksBackend.Modules.Applications.Endpoints;

public static class GetAppBorrowerByAppIDEndPoint
{
    /// <summary>
    /// Returns AppBorrower Details based on given AppID 
    /// </summary>
    /// <param name="mediator"></param>
    /// <param name="appId"></param>
    /// <returns></returns>
    [ProducesResponseType(typeof(ApplicationBorrower), StatusCodes.Status200OK)]
    public static async Task<IResult> Handle(int appId, IMediator mediator)
    {
        var response = await mediator.Send(new GetAppBorrowerByAppIDQuery() { AppId = appId });

        if (response == null || response.Count() == 0)
            return Results.NotFound();
        else
            return Results.Ok(response);
    }
}

