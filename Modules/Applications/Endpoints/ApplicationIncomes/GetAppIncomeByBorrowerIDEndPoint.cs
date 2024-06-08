using LoanworksBackend.Modules.Applications.Core.ApplicationIncomes;
using LoanworksBackend.Modules.Applications.Query.ApplicationIncomes;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoanworksBackend.Modules.Applications.Endpoints;

public static class GetAppIncomeByBorrowerIDEndPoint
{
    /// <summary>
    /// Returns AppIncome Details based on given BorrowerId
    /// </summary>
    /// <param name="mediator"></param>
    /// <param name="borrowerId"></param>
    /// <returns></returns>
    [ProducesResponseType(typeof(ApplicationIncome), StatusCodes.Status200OK)]
    public static async Task<IResult> Handle(int borrowerId, IMediator mediator)
    {
        var response = await mediator.Send(new GetAppIncomeByBorrowerIDQuery() { BorrowerId = borrowerId });

        if (response == null || response.Count() == 0)
            return Results.NotFound();
        else
            return Results.Ok(response);
    }
}

