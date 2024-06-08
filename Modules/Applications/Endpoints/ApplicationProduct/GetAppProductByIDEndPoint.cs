using LoanworksBackend.Modules.Applications.Core.ApplicationProduct;
using LoanworksBackend.Modules.Applications.Query.ApplicationProduct;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoanworksBackend.Modules.Applications.Endpoints;

public static class GetAppProductByIDEndPoint
{
    /// <summary>
    /// Returns ApplicationProduct Details based on given AppProduct By Id
    /// </summary>
    /// <param name="mediator"></param>
    /// <param name="appProductId"></param>
    /// <returns></returns>  
    [ProducesResponseType(typeof(AppProduct), StatusCodes.Status200OK)]  
    public static async Task<IResult> Handle(int appProductId, IMediator mediator)
    {
        var response = await mediator.Send(new GetAppProductByIDQuery() { AppProductId = appProductId });

        if (response == null || response.Count() == 0)
            return Results.NotFound();
        else
            return Results.Ok(response.FirstOrDefault());
    }
}

