using LoanworksBackend.Modules.Applications.Core.FeeExceptions;
using LoanworksBackend.Modules.Applications.Query.FeeExceptions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoanworksBackend.Modules.Applications.Endpoints.FeeExceptions;

public static class GetFeeExceptionsByAppIDEndPoint
{
    /// <summary>
    /// Returns AppProductFees Details based on given AppID,legalcode and valuationcode
    /// </summary>
    /// <param name="mediator"></param>
    /// <param name="appId"></param>
    /// <param name="legalCode"></param>
    /// <param name="valuationCode"></param>
    /// <returns></returns>
    [ProducesResponseType(typeof(List<FeeException>), StatusCodes.Status200OK)]
    public static async Task<IResult> Handle(int appId, int legalCode, int valuationCode, IMediator mediator)
    {
        var response = await mediator.Send(new GetFeeExceptionsByAppIDQuery() { AppId = appId, LegalCode = legalCode, ValuationCode = valuationCode });

        if (response == null)
            return Results.NotFound();
        else
            return Results.Ok(response);
    }
}
