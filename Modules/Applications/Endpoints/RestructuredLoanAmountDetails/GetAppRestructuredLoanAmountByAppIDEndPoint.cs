using LoanworksBackend.Modules.Applications.Core.RestructuredLoanAmountDetails;
using LoanworksBackend.Modules.Applications.Query.RestructuredLoanAmountDetails;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoanworksBackend.Modules.Applications.Endpoints.RestructuredLoanAmountDetails;

public static class GetAppRestructuredLoanAmountByAppIDEndPoint
{
    /// <summary>
    /// Returns Application RestructuredLoanAmount Calculation Details based on given AppId
    /// </summary>
    /// <param name="mediator"></param>
    /// <param name="appId"></param>
    /// <returns></returns>
    [ProducesResponseType(typeof(List<RestructuredLoanAmountDetail>), StatusCodes.Status200OK)]
    public static async Task<IResult> Handle(int appId, IMediator mediator)
    {
        var response = await mediator.Send(new GetAppRestructuredLoanAmountByAppIDQuery() { AppId = appId });

        if (response == null)
            return Results.NotFound();
        else
            return Results.Ok(response);
    }
}
