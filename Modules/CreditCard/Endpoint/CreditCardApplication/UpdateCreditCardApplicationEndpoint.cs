using LoanworksBackend.Modules.CreditCard.Commands.Application;
using LoanworksBackend.Modules.CreditCard.Core.CreditCardApplication;

using LoanworksBackend.Modules.CreditCard.Query.Application;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoanworksBackend.Modules.CreditCard.Endpoint.Application;

/// <summary>
///
/// </summary>
public static class UpdateCreditCardApplicationEndpoint
{
    /// <summary>
    /// Updates Application Class
    /// </summary>
    /// <param name="ApplicationClass"></param>
    /// <param name="mediator"></param>
    /// <returns></returns>
    [ProducesResponseType(typeof(List<CreditCardApplication>), StatusCodes.Status200OK)]
    public static async Task<IResult> Handle([FromBody] CreditCardApplication CreditCardApplication, IMediator mediator)
    {
        var response = await mediator.Send(new UpdateCreditCardApplicationCommand(){ CreditCardApplication = CreditCardApplication });

        if (response == null)
            return Results.NotFound();
        else
            return Results.Ok(response);
    }
}
