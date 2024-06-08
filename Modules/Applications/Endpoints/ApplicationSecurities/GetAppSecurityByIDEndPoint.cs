using LoanworksBackend.Modules.Applications.Core.ApplicationSecurities;
using LoanworksBackend.Modules.Applications.Query.ApplicationSecurities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoanworksBackend.Modules.Applications.Endpoints;

public static class GetAppSecurityByIDEndPoint
{
    /// <summary>
    /// Returns ApplicationSecurity Details based on given AppSecurity By Id
    /// </summary>
    /// <param name="mediator"></param>
    /// <param name="securityId"></param>
    /// <returns></returns>  
    [ProducesResponseType(typeof(ApplicationSecurity), StatusCodes.Status200OK)]
    public static async Task<IResult> Handle(int securityId, IMediator mediator)
    {
        var response = await mediator.Send(new GetAppSecurityByIDQuery() { SecurityId = securityId });

        if (response == null || response.Count() == 0)
            return Results.NotFound();
        else
            return Results.Ok(response.FirstOrDefault());
    }
}

