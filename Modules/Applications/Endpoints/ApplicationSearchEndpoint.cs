using LoanworksBackend.Modules.Applications.Core;
using LoanworksBackend.Modules.Applications.Query.Applications;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoanworksBackend.Modules.Applications.Endpoints;

/// <summary>
/// API Endpoint for searching applications
/// </summary>
public static class ApplicationSearchEndpoint
{
    /// <summary>
    /// Searches applications in the system based on the filter input
    /// </summary>
    /// <param name="input"></param>
    /// <param name="mediator"></param>
    /// <returns></returns>
    [ProducesResponseType(StatusCodes.Status200OK)]
    public static async Task<IResult> Handle([FromBody] ApplicationSearchInput input, IMediator mediator)
    {
        var result = await mediator.Send(new SearchApplicationsQuery()
        {
            UserId = 5
        });

        return result == null ? Results.NotFound() : Results.Ok(result);
    }
}
