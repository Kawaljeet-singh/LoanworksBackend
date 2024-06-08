using LoanworksBackend.Dal;
using LoanworksBackend.Modules.Applications.Core.AppStatus;
using MediatR;
using RepoDb;

namespace LoanworksBackend.Modules.Applications.Query.AppStatus;

public class GetAppStatusByAppIDQuery : IRequest<List<ApplicationStatus>>
{
    public int AppId { get; set; } = default!;
}
public class GetAppStatusByAppIDQueryHandler : LosDbQueryHandler, IRequestHandler<GetAppStatusByAppIDQuery, List<ApplicationStatus>>
{
    public GetAppStatusByAppIDQueryHandler(IDbContext dbContext) : base(dbContext)
    {

    }
    public async Task<List<ApplicationStatus>> Handle(GetAppStatusByAppIDQuery request, CancellationToken cancellationToken)
    {
        var response = await base.DbContext.Connection.ExecuteQueryAsync<ApplicationStatus>("EXEC USP_AppStatusGet @AppId", new { AppId = request.AppId });

        if (response == null)
            return new List<ApplicationStatus>();
        else
            return response.ToList();
    }
}

