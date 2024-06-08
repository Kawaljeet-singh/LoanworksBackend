using LoanworksBackend.Modules.Applications.Core.ApplicationLiabilities;
using LoanworksBackend.Modules.Applications.Query.ApplicationLiabilities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoanworksBackend.Modules.Applications.Endpoints.ApplicationLiabilities;

public static class GetAppLiabilitiesByBorrowerIDEndPoint
{
    /// <summary>
    /// Returns AppLiabilities Details based on given BorrowerID 
    /// </summary>
    /// <param name="mediator"></param>
    /// <param name="borrowerId"></param>
    /// <returns></returns>
    [ProducesResponseType(typeof(ApplicationLiability), StatusCodes.Status200OK)]
    public static async Task<IResult> Handle(int borrowerId, IMediator mediator)
    {
        var response = await mediator.Send(new GetAppLiabilitiesByBorrowerIDQuery() { BorrowerId = borrowerId });

        if (response == null || response.Count() == 0)
            return Results.NotFound();
        else
            return Results.Ok(response);
    }
}

