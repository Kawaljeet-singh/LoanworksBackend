using LoanworksBackend.Dal;
using LoanworksBackend.Modules.Applications.Core.ApplicationBorrowers;
using MediatR;
using RepoDb;

namespace LoanworksBackend.Modules.Applications.Query.ApplicationBorrowers;

public class GetAppBorrowerByAppIDQuery : IRequest<List<ApplicationBorrower>>
{
    public int AppId { get; set; }
}
public class GetAppBorrowerByAppIDQueryHandler : LosDbQueryHandler, IRequestHandler<GetAppBorrowerByAppIDQuery, List<ApplicationBorrower>>
{
    public GetAppBorrowerByAppIDQueryHandler(IDbContext dbContext) : base(dbContext)
    {

    }
    public async Task<List<ApplicationBorrower>> Handle(GetAppBorrowerByAppIDQuery request, CancellationToken cancellationToken)
    {
        var response = await base.DbContext.Connection.QueryAsync<ApplicationBorrower>(a => a.AppId == request.AppId);

        if (response == null)
            return new List<ApplicationBorrower>();
        else
            return response.ToList();
    }
}


