using LoanworksBackend.Modules.Applications.Commands.ApplicationLoans;
using LoanworksBackend.Modules.Applications.Core.ApplicationLoans;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoanworksBackend.Modules.Applications.Endpoints.ApplicationLoans;

public static class DeleteApplicationLoanEndPoint
{
    /// <summary>
    /// Delete Record in ApplicationLoanClass
    /// </summary>
    /// <param name="mediator"></param>
    /// <param name="DeleteApplicationLoanClass"></param>
    /// <returns></returns>
    [ProducesResponseType(typeof(List<ApplicationLoan>), StatusCodes.Status200OK)]
    public static async Task<IResult> Handle([FromBody] ApplicationLoan DeleteApplicationLoanClass, IMediator mediator)
    {
        var response = await mediator.Send(new DeleteApplicationLoanClassCommand() { DeleteApplicationLoanClass = DeleteApplicationLoanClass });

        if (response == null)
            return Results.NotFound();
        else
            return Results.Ok(response);
    }
}


