using LoanworksBackend.Modules.Applications.Core.ApplicationBorrowers;
using LoanworksBackend.Modules.Applications.Query.ApplicationBorrowers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoanworksBackend.Modules.Applications.Endpoints.ApplicationBorrowers;

public static class GetAppBorrowerByIDEndPoint
{
    /// <summary>
    ///  Returns AppBorrower Details based on given AppBorrower By Id
    /// </summary>
    /// <param name="mediator"></param>
    /// <param name="borrowerId"></param>
    /// <returns></returns>  
    [ProducesResponseType(typeof(ApplicationBorrower), StatusCodes.Status200OK)]
    public static async Task<IResult> Handle(int borrowerId, IMediator mediator)
    {
        var response = await mediator.Send(new GetAppBorrowerByIDQuery() { BorrowerId = borrowerId });

        if (response == null || response.Count() == 0)
            return Results.NotFound();
        else
            return Results.Ok(response.FirstOrDefault());
    }
}

