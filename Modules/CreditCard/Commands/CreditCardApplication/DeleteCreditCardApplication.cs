using System.ComponentModel.DataAnnotations;
using LoanworksBackend.Dal;
using LoanworksBackend.Modules.CreditCard.Core.CreditCardApplication;
using MediatR;
using RepoDb;

namespace LoanworksBackend.Modules.CreditCard.Commands.Application;

public class DeleteCreditCardApplicationCommand: IRequest<List<CreditCardApplication>>
{ 
   public int Id { get; internal set; }  
}

public class DeleteCreditCardApplicationCommandHandler : LosDbQueryHandler, IRequestHandler<DeleteCreditCardApplicationCommand, List<CreditCardApplication>>
{
    public DeleteCreditCardApplicationCommandHandler(IDbContext dbContext) : base(dbContext)
    {

    }

    public async Task<List<CreditCardApplication>> Handle(DeleteCreditCardApplicationCommand request, CancellationToken cancellationToken)
    {
        var response = await base.DbContext.Connection.ExecuteQueryAsync<CreditCardApplication>("EXEC sp_ApplicationClass_Delete_ByID " + request.Id);

        if (response == null)
            return new List<CreditCardApplication>();
        else
            return response.ToList();
    }
}
