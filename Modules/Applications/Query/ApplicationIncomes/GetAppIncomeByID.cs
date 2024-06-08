using LoanworksBackend.Dal;
using LoanworksBackend.Modules.Applications.Core.ApplicationIncomes;
using MediatR;
using RepoDb;

namespace LoanworksBackend.Modules.Applications.Query.ApplicationIncomes;

public class GetAppIncomeByIDQuery : IRequest<List<ApplicationIncome>>
{
    public int IncomeId { get; set; }
}
public class GetAppIncomeByIDQueryHandler : LosDbQueryHandler, IRequestHandler<GetAppIncomeByIDQuery, List<ApplicationIncome>>
{
    public GetAppIncomeByIDQueryHandler (IDbContext dbContext) : base(dbContext)
    {

    }
    public async Task<List<ApplicationIncome>> Handle(GetAppIncomeByIDQuery request, CancellationToken cancellationToken)
    {
        var response = await base.DbContext.Connection.QueryAsync<ApplicationIncome>(a => a.IncomeId == request.IncomeId);

        if (response == null)
            return new List<ApplicationIncome>();
        else
            return response.ToList();
    }
}


