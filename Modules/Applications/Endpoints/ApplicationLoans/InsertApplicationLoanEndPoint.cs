
using LoanworksBackend.Modules.Applications.Commands.ApplicationLoans;
using LoanworksBackend.Modules.Applications.Core.ApplicationLoans;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoanworksBackend.Modules.Applications.Endpoints.ApplicationLoans;

public static class InsertApplicationLoanEndPoint
{
    /// <summary>
    /// Insert Record in Application Loan Class
    /// </summary>
    /// <param name="mediator"></param>
    /// <param name="InsertApplicationLoanClass"></param>
    /// <returns></returns>
    [ProducesResponseType(typeof(List<ApplicationLoan>), StatusCodes.Status200OK)]
    public static async Task<IResult> Handle([FromBody] ApplicationLoan InsertApplicationLoanClass, IMediator mediator)
    {
        var response = await mediator.Send(new InsertApplicationLoanClassCommand() { InsertApplicationLoanClass = InsertApplicationLoanClass });

        if (response == null)
            return Results.NotFound();
        else
            return Results.Ok(response);
    }
}

