using LoanworksBackend.Modules.Management.Commands.Management;
using LoanworksBackend.Modules.Management.Core.Application_Loan;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoanworksBackend.Modules.Management.Endpoint.Management;

/// <summary>
/// API endpoint that gets all the funds position for management
/// </summary>
public static class DeleteApplicationLoanClassEndpoint
{
    /// <summary>
    /// Delete Record in Application Loan Class
    /// </summary>
    /// <param name="mediator"></param>
    /// <param name="applicationClassId"></param>
    /// <returns></returns>
    [ProducesResponseType(typeof(List<DeleteApplicationLoanClass>), StatusCodes.Status200OK)]
    public static async Task<IResult> Handle(int applicationClassId, IMediator mediator)
    {
        var response = await mediator.Send(new DeleteApplicationLoanClassCommand(){ ApplicationClassID = applicationClassId });

        if (response == null)
            return Results.NotFound();
        else
            return Results.Ok(response);
    }
}
