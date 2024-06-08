using LoanworksBackend.Dal;
using MediatR;
using RepoDb;

namespace LoanworksBackend.Modules.Applications.Query.Applications;

public class SearchApplicationsQuery : IRequest<List<Core.Application>>
{
    public int UserId { get; set; }
}

public class SearchApplicationsQueryHandler : LosDbQueryHandler, IRequestHandler<SearchApplicationsQuery, List<Core.Application>>
{
    public SearchApplicationsQueryHandler(IDbContext dbContext) : base(dbContext)
    {

    }

    public async Task<List<Core.Application>> Handle(SearchApplicationsQuery request, CancellationToken cancellationToken)
    {
        var response
            = await base.DbContext.Connection.ExecuteQueryAsync<Core.Application>("EXEC sp_appGetApplications", new
            {
                iUserID = 5
            });

        if (response == null || response.Count() == 0)
            return new List<Core.Application>();
        else
            return response.ToList();
    }
}
