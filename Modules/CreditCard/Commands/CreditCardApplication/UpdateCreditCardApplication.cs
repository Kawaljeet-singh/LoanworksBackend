using System.ComponentModel.DataAnnotations;
using LoanworksBackend.Dal;
using LoanworksBackend.Modules.CreditCard.Core.CreditCardApplication;
using MediatR;
using RepoDb;

namespace LoanworksBackend.Modules.CreditCard.Commands.Application;

public class UpdateCreditCardApplicationCommand : IRequest<List<CreditCardApplication>>
{
   public CreditCardApplication CreditCardApplication { get; internal set; } = default!;
  
}

public class UpdateCreditCardApplicationCommandHandler : LosDbQueryHandler, IRequestHandler<UpdateCreditCardApplicationCommand, List<CreditCardApplication>>
{
    public UpdateCreditCardApplicationCommandHandler(IDbContext dbContext) : base(dbContext)
    {

    }

    public async Task<List<CreditCardApplication>> Handle(UpdateCreditCardApplicationCommand request, CancellationToken cancellationToken)
    {
        var response = await base.DbContext.Connection.ExecuteQueryAsync<CreditCardApplication>("EXEC sp_ApplicationClass_Update_ByID " + request.CreditCardApplication.Id  + ", '" + request.CreditCardApplication.Name + "'," +  request.CreditCardApplication.Status + "," + request.CreditCardApplication.FeeType);

        if (response == null)
            return new List<CreditCardApplication>();
        else
            return response.ToList();
    }
}
