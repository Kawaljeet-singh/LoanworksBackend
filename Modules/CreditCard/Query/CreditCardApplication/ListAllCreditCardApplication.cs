using LoanworksBackend.Dal;
using LoanworksBackend.Modules.CreditCard.Core.CreditCardApplication;
using MediatR;
using RepoDb;

namespace LoanworksBackend.Modules.CreditCard.Query.Application;

public class ListAllCreditCardApplicationQuery : IRequest<List<CreditCardApplicationGetList>>
{
     
}

public class ListAllCreditCardApplicationQueryHandler : LosDbQueryHandler, IRequestHandler<ListAllCreditCardApplicationQuery, List<CreditCardApplicationGetList>>
{
    public ListAllCreditCardApplicationQueryHandler(IDbContext dbContext) : base(dbContext)
    {

    }

    public async Task<List<CreditCardApplicationGetList>> Handle(ListAllCreditCardApplicationQuery request, CancellationToken cancellationToken)
    {
        var response = await base.DbContext.Connection.ExecuteQueryAsync<CreditCardApplicationGetList>("EXEC sp_ApplicationClass_Get_List");

        if (response == null)
            return new List<CreditCardApplicationGetList>();
        else
            return response.ToList();
    }
}
