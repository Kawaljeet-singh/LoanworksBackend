using LoanworksBackend.Modules.Applications.Core;
using LoanworksBackend.Modules.Applications.Query.Applications;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoanworksBackend.Modules.Applications.Endpoints;

public static class GetAppSummaryByAppIDEndPoint
{
    /// <summary>
    /// Returns AppSummary Details based on given AppID
    /// </summary>
    /// <param name="mediator"></param>
    /// <param name="appId"></param>
    /// <returns></returns>
    [ProducesResponseType(typeof(List<Application>), StatusCodes.Status200OK)]
    public static async Task<IResult> Handle(int appId, IMediator mediator)
    {
        var response = await mediator.Send(new GetAppSummaryByAppIDQuery() { AppId = appId });

        if (response == null)
            return Results.NotFound();
        else
            return Results.Ok(response);
    }
}

