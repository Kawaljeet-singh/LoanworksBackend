using System.ComponentModel.DataAnnotations;
using LoanworksBackend.Dal;
using LoanworksBackend.Modules.CreditCard.Core.CreditCardApplication;
using MediatR;
using RepoDb;

namespace LoanworksBackend.Modules.CreditCard.Commands.Application;

public class InsertCreditCardApplicationCommand : IRequest<List<CreditCardApplication>>
{
   public CreditCardApplication CreditCardApplication { get; internal set; } = default!;
  
}

public class InsertCreditCardApplicationCommandHandler : LosDbQueryHandler, IRequestHandler<InsertCreditCardApplicationCommand, List<CreditCardApplication>>
{
    public InsertCreditCardApplicationCommandHandler(IDbContext dbContext) : base(dbContext)
    {

    }

    public async Task<List<CreditCardApplication>> Handle(InsertCreditCardApplicationCommand request, CancellationToken cancellationToken)
    {
        CreditCardApplication apps = request.CreditCardApplication;
        List<CreditCardApplication> response=new List<CreditCardApplication>();
        response.Add(apps);
        return response;
//        var response = await base.DbContext.Connection.ExecuteQueryAsync<CreditCardApplication>("EXEC sp_ApplicationClass_Insert '" + request.CreditCardApplication.Name  + "'");

  //      if (response == null)
    //        return new List<CreditCardApplication>();
      //  else
        //    return response.ToList();
    }
}
