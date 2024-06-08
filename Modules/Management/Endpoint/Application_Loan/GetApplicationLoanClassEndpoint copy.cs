using LoanworksBackend.Modules.Management.Core.Application_Loan;
using LoanworksBackend.Modules.Management.Query.Management;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoanworksBackend.Modules.Management.Endpoint.Management;

/// <summary>
/// API endpoint that gets all the funds position for management
/// </summary>
public static class GetApplicationLoanClassEndpoint
{
    /// <summary>
    /// Returns the list of Loan Class in Application By specified ID
    /// </summary>
    /// <param name="mediator"></param>
    /// <param name="applicationClassId"></param>
    /// <returns></returns>
    [ProducesResponseType(typeof(List<ApplicationLoanClass>), StatusCodes.Status200OK)]
    public static async Task<IResult> Handle(int applicationClassId, IMediator mediator)
    {
        var response = await mediator.Send(new GetApplicationLoanClassQuery(){ ApplicationClassID = applicationClassId });

        if (response == null)
            return Results.NotFound();
        else
            return Results.Ok(response);
    }
}
