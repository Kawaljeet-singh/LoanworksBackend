using LoanworksBackend.Modules.Applications.Core.ApplicationProduct;
using LoanworksBackend.Modules.Applications.Query.ApplicationProduct;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoanworksBackend.Modules.Applications.Endpoints;

public static class GetAppProductByAppIDEndPoint
{
    /// <summary>
    /// Returns ApplicationProduct Details based on given AppID 
    /// </summary>
    /// <param name="mediator"></param>
    /// <param name="appId"></param>
    /// <returns></returns>
    [ProducesResponseType(typeof(AppProduct), StatusCodes.Status200OK)]
    public static async Task<IResult> Handle(int appId, IMediator mediator)
    {
        var response = await mediator.Send(new GetAppProductByAppIDQuery() { AppId = appId });

        if (response == null || response.Count() == 0)
            return Results.NotFound();
        else
            return Results.Ok(response);        
    }
}

