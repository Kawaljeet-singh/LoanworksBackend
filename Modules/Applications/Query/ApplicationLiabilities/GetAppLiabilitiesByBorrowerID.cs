using LoanworksBackend.Dal;
using LoanworksBackend.Modules.Applications.Core.ApplicationLiabilities;
using MediatR;
using RepoDb;

namespace LoanworksBackend.Modules.Applications.Query.ApplicationLiabilities;

public class GetAppLiabilitiesByBorrowerIDQuery : IRequest<List<ApplicationLiability>>
{
    public int BorrowerId { get; set; }
}
public class GetAppLiabilitiesByBorrowerIDQueryHandler : LosDbQueryHandler, IRequestHandler<GetAppLiabilitiesByBorrowerIDQuery, List<ApplicationLiability>>
{
    public GetAppLiabilitiesByBorrowerIDQueryHandler(IDbContext dbContext) : base(dbContext)
    {

    }
    public async Task<List<ApplicationLiability>> Handle(GetAppLiabilitiesByBorrowerIDQuery request, CancellationToken cancellationToken)
    {
        var response = await base.DbContext.Connection.QueryAsync<ApplicationLiability>(a => a.BorrowerId == request.BorrowerId);

        if (response == null)
            return new List<ApplicationLiability>();
        else
            return response.ToList();
    }
}


