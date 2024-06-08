using LoanworksBackend.Modules.Applications.Core.AppProductFunders;
using LoanworksBackend.Modules.Applications.Query.AppProductFunders;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoanworksBackend.Modules.Applications.Endpoints.AppProductFunders;

public static class GetAppProductFundersByAppIDEndPoint
{
    /// <summary>
    /// Returns AppProductFunders Details based on given AppID 
    /// </summary>
    /// <param name="mediator"></param>
    /// <param name="userId"></param>
    /// <param name="appId"></param>
    /// <returns></returns>
    [ProducesResponseType(typeof(List<AppProductFunder>), StatusCodes.Status200OK)]
    public static async Task<IResult> Handle(int userId, int appId, IMediator mediator)
    {
        var response = await mediator.Send(new GetAppProductFundersByAppIDQuery() { UserId = userId, AppId = appId });

        if (response == null || response.Count() == 0)
            return Results.NotFound();
        else
            return Results.Ok(response);
    }
}
