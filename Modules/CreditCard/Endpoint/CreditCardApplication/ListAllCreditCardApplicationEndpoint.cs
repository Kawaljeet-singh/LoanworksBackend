using LoanworksBackend.Modules.CreditCard.Core.CreditCardApplication;

using LoanworksBackend.Modules.CreditCard.Query.Application;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoanworksBackend.Modules.CreditCard.Endpoint.Application;

/// <summary>
/// API endpoint that gets all the funds position for management
/// </summary>
public static class ListAllCreditCardApplicationEndpoint
{
    /// <summary>
    /// Returns the list of Application Class
    /// </summary>
    /// <param name="mediator"></param>
    /// <returns></returns>
    [ProducesResponseType(typeof(List<CreditCardApplication>), StatusCodes.Status200OK)]
    public static async Task<IResult> Handle(IMediator mediator)
    {
        //var response = await mediator.Send(new ListAllApplicationClassQuery());

        //if (response == null)
        //    return Results.NotFound();
       // else
            return Results.Ok("hello");
    }
}
