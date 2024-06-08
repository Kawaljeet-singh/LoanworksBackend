using LoanworksBackend.Dal;
using LoanworksBackend.Modules.CreditCard.Core.CreditCardApplication;
using MediatR;
using RepoDb;

namespace LoanworksBackend.Modules.CreditCard.Query.Application;

public class GetCreditCardApplicationQuery : IRequest<List<CreditCardApplication>>
{
    public int Id { get; set; }
}

public class GetCreditCardApplicationQueryHandler : LosDbQueryHandler, IRequestHandler<GetCreditCardApplicationQuery, List<CreditCardApplication>>
{
    public GetCreditCardApplicationQueryHandler(IDbContext dbContext) : base(dbContext)
    {

    }

    public async Task<List<CreditCardApplication>> Handle(GetCreditCardApplicationQuery request, CancellationToken cancellationToken)
    {
        var response = await base.DbContext.Connection.ExecuteQueryAsync<CreditCardApplication>("EXEC sp_ApplicationClass_Get_ByID " + request.Id);

        if (response == null)
            return new List<CreditCardApplication>();
        else
            return response.ToList();
    }
}
