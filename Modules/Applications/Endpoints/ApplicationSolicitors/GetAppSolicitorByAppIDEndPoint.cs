using LoanworksBackend.Modules.Applications.Core.ApplicationSolicitors;
using LoanworksBackend.Modules.Applications.Query.ApplicationSolicitors;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoanworksBackend.Modules.Applications.Endpoints.ApplicationSolicitors;

public static class GetAppSolicitorByAppIDEndPoint
{
    /// <summary>
    /// Returns AppSolicitor Details based on given AppID 
    /// </summary>
    /// <param name="mediator"></param>
    /// <param name="userId"></param>
    /// <param name="appId"></param>
    /// <returns></returns>
    [ProducesResponseType(typeof(List<ApplicationSolicitor>), StatusCodes.Status200OK)]
    public static async Task<IResult> Handle(int userId, int appId, IMediator mediator)
    {
        var response = await mediator.Send(new GetAppSolicitorByAppIDQuery() {UserId = userId, AppId = appId });

        if (response == null || response.Count() == 0)
            return Results.NotFound();
        else
            return Results.Ok(response);
    }
}
