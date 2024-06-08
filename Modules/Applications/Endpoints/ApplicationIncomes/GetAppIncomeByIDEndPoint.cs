using LoanworksBackend.Modules.Applications.Core.ApplicationIncomes;
using LoanworksBackend.Modules.Applications.Query.ApplicationIncomes;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoanworksBackend.Modules.Applications.Endpoints;

public static class GetAppIncomeByIDEndPoint
{
    /// <summary>
    /// Returns ApplicationIncome Details based on given AppIncome By Id
    /// </summary>
    /// <param name="mediator"></param>
    /// <param name="incomeId"></param>
    /// <returns></returns>  
    [ProducesResponseType(typeof(ApplicationIncome), StatusCodes.Status200OK)]
    public static async Task<IResult> Handle(int incomeId, IMediator mediator)
    {
        var response = await mediator.Send(new GetAppIncomeByIDQuery() { IncomeId = incomeId });

        if (response == null || response.Count() == 0)
            return Results.NotFound();
        else
            return Results.Ok(response.FirstOrDefault());
    }
}

