using LoanworksBackend.Modules.CreditCard.Commands.Application;
using LoanworksBackend.Modules.CreditCard.Core.CreditCardApplication;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoanworksBackend.Modules.CreditCard.Endpoint.Application;


public static class DeleteCreditCardApplicationEndpoint
{
    /// <summary>
    /// Deletes Record in the Application Class
    /// </summary>
    /// <param name="mediator"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    [ProducesResponseType(typeof(List<CreditCardApplication>), StatusCodes.Status200OK)]
    public static async Task<IResult> Handle(int id, IMediator mediator)
    {
        var response = await mediator.Send(new DeleteCreditCardApplicationCommand() { Id = id });

        if (response == null)
            return Results.NotFound();
        else
            return Results.Ok(response);
    }
}
