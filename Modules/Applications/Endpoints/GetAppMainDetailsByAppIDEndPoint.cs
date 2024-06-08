using LoanworksBackend.Modules.Applications.Core;
using LoanworksBackend.Modules.Applications.Query.Applications;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoanworksBackend.Modules.Applications.Endpoints;

public static class GetAppMainDetailsByAppIDEndPoint
{
    /// <summary>
    /// Returns AppMain Details based on given AppID 
    /// </summary>
    /// <param name="mediator"></param>
    /// <param name="appId"></param>
    /// <returns></returns>
    [ProducesResponseType(typeof(Application), StatusCodes.Status200OK)]
    public static async Task<IResult> Handle(int appId, IMediator mediator)
    {
        var response = await mediator.Send(new GetAppMainDetailsByAppIDQuery() { AppId = appId });

        if (response == null || response.Count() == 0)
            return Results.NotFound();
        else
            return Results.Ok(response.FirstOrDefault());
    }
}

