using LoanworksBackend.Modules.Applications.Core.AppStatus;
using LoanworksBackend.Modules.Applications.Query.AppStatus;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoanworksBackend.Modules.Applications.Endpoints;

public static class GetAppStatusByAppIDEndPoint
{
    /// <summary>
    /// Returns ApplicationSatus Details based on given AppID
    /// </summary>
    /// <param name="mediator"></param>
    /// <param name="appId"></param>
    /// <returns></returns>
    [ProducesResponseType(typeof(List<ApplicationStatus>), StatusCodes.Status200OK)]
    public static async Task<IResult> Handle(int appId, IMediator mediator)
    {
        var response = await mediator.Send(new GetAppStatusByAppIDQuery() { AppId = appId });

        if (response == null)
            return Results.NotFound();
        else
            return Results.Ok(response);
    }
}

