using LoanworksBackend.Modules.Applications.Core.ApplicationProduct;
using LoanworksBackend.Modules.Applications.Query.ApplicationProduct;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoanworksBackend.Modules.Applications.Endpoints;

public static class GetAppProductFeatureActiveEndPoint
{
    /// <summary>
    /// Returns ProductFeature Details based on given ProductId and AppProductId
    /// </summary>
    /// <param name="mediator"></param>
    /// <param name="ProductId"></param>
    /// <param name="AppProductId"></param>
    /// <returns></returns>
    [ProducesResponseType(typeof(List<AppProductFeature>), StatusCodes.Status200OK)]
    public static async Task<IResult> Handle(int ProductId, int AppProductId, IMediator mediator)
    {
        var response = await mediator.Send(new GetAppProductFeatureActiveQuery() { ProductId = ProductId, AppProductId = AppProductId });

        if (response == null)
            return Results.NotFound();
        else
            return Results.Ok(response);
    }
}

