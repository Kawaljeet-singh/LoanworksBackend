using LoanworksBackend.Modules.Applications.Core.ApplicationSecurities;
using LoanworksBackend.Modules.Applications.Query.ApplicationSecurities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoanworksBackend.Modules.Applications.Endpoints;

public static class GetAppSecurityByAppIDEndPoint
{
    /// <summary>
    /// Returns AppSecurity Details based on given AppID 
    /// </summary>
    /// <param name="mediator"></param>
    /// <param name="appId"></param>
    /// <returns></returns>
    [ProducesResponseType(typeof(ApplicationSecurity), StatusCodes.Status200OK)]
    public static async Task<IResult> Handle(int appId, IMediator mediator)
    {
        var response = await mediator.Send(new GetAppSecurityByAppIDQuery() { AppId = appId });

        if (response == null || response.Count() == 0)
            return Results.NotFound();
        else
            return Results.Ok(response);
    }
}

