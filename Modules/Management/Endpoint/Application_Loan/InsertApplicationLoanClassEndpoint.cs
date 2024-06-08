using LoanworksBackend.Modules.Management.Commands.Management;
using LoanworksBackend.Modules.Management.Core.Application_Loan;

using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoanworksBackend.Modules.Management.Endpoint.Management;

/// <summary>
/// API endpoint that gets all the funds position for management
/// </summary>
public static class InsertApplicationLoanClassEndpoint
{
    /// <summary>
    /// Insert Record n Application Loan Class
    /// </summary>
    /// <param name="mediator"></param>
    /// <param name="appLoanClassInsert"></param>
 
    /// <returns></returns>
    [ProducesResponseType(typeof(List<ApplicationLoanClassInsert>), StatusCodes.Status200OK)]
    public static async Task<IResult> Handle([FromBody] ApplicationLoanClassInsert appLoanClassInsert, IMediator mediator)
    {
        var response = await mediator.Send(new InsertApplicationLoanClassCommand(){ AppLoanClassInsert = appLoanClassInsert });

        if (response == null)
            return Results.NotFound();
        else
            return Results.Ok(response);
    }
}
