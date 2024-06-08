using LoanworksBackend.Dal;
using LoanworksBackend.Modules.Applications.Core;
using MediatR;
using RepoDb;

namespace LoanworksBackend.Modules.Applications.Query.Applications;

public class GetAppSummaryByAppIDQuery : IRequest<List<Application>>
{
    public int AppId { get; set; } = default!;
}
public class GetAppSummaryByAppIDQueryHandler : LosDbQueryHandler, IRequestHandler<GetAppSummaryByAppIDQuery, List<Application>>
{
    public GetAppSummaryByAppIDQueryHandler(IDbContext dbContext) : base(dbContext)
    {

    }
    public async Task<List<Application>> Handle(GetAppSummaryByAppIDQuery request, CancellationToken cancellationToken)
    {
        var response = await base.DbContext.Connection.ExecuteQueryAsync<Application>("EXEC sp_appGetAppSummary @AppId", new { AppId = request.AppId });

        if (response == null)
            return new List<Application>();
        else
            return response.ToList();
    }
}


