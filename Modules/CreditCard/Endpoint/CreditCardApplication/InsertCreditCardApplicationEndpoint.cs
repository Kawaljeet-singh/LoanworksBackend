using System.Net;
using LoanworksBackend.Modules.CreditCard.Commands.Application;
using LoanworksBackend.Modules.CreditCard.Core.CreditCardApplication;
using LoanworksBackend.Modules.CreditCard.Validators.Application;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoanworksBackend.Modules.CreditCard.Endpoint.Application;


public static class InsertCreditCardApplicationEndpoint
{
    /// <summary>
    /// Inserts Record in the Application Class
    /// </summary>
    /// <param name="mediator"></param>
    /// <param name="ApplicationClass"></param>
    /// <returns></returns>

    [ProducesResponseType(typeof(List<CreditCardApplication>), StatusCodes.Status200OK)]
    public static async Task<IResult> Handle([FromBody] CreditCardApplication CreditCardApplication, IMediator mediator)
    {
        InsertCreditCardApplicationValidator validator = new InsertCreditCardApplicationValidator();
        FluentValidation.Results.ValidationResult results = validator.Validate(CreditCardApplication);
        System.Diagnostics.Debug.WriteLine(results);
        if (!results.IsValid)
        {
            return Results.BadRequest(results.Errors);
        }
        
        var response = await mediator.Send(new InsertCreditCardApplicationCommand(){CreditCardApplication = CreditCardApplication });
        return Results.Ok(CreditCardApplication.Name);

        //if (response == null)
        //    return Results.NotFound();
        //else
        //  return Results.Ok(response);
    }
}
