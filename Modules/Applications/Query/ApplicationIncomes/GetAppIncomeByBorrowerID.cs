using LoanworksBackend.Dal;
using LoanworksBackend.Modules.Applications.Core.ApplicationIncomes;
using MediatR;
using RepoDb;

namespace LoanworksBackend.Modules.Applications.Query.ApplicationIncomes;

public class GetAppIncomeByBorrowerIDQuery :IRequest<List<ApplicationIncome>>
{
    public int BorrowerId { get; set; }
}
public class GetAppIncomeByBorrowerIDQueryHandler : LosDbQueryHandler, IRequestHandler<GetAppIncomeByBorrowerIDQuery, List<ApplicationIncome>>
{
    public GetAppIncomeByBorrowerIDQueryHandler(IDbContext dbContext) : base(dbContext)
    {

    }
    public async Task<List<ApplicationIncome>> Handle(GetAppIncomeByBorrowerIDQuery request, CancellationToken cancellationToken)
    {
        var response = await base.DbContext.Connection.QueryAsync<ApplicationIncome>(a => a.BorrowerId == request.BorrowerId);

        if (response == null)
            return new List<ApplicationIncome>();
        else
            return response.ToList();
    }
}


