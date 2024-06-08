using LoanworksBackend.Dal;
using LoanworksBackend.Modules.Applications.Core.AppProductFunders;
using MediatR;
using RepoDb;

namespace LoanworksBackend.Modules.Applications.Query.AppProductFunders;

public class GetAppProductFundersByAppIDQuery : IRequest<List<AppProductFunder>>
{
    public int UserId { get; set; }
    public int AppId { get; set; }
}
public class GetAppProductFundersByAppIDQueryHandler : LosDbQueryHandler, IRequestHandler<GetAppProductFundersByAppIDQuery, List<AppProductFunder>>
{
    public GetAppProductFundersByAppIDQueryHandler(IDbContext dbContext) : base(dbContext)
    {

    }
    public async Task<List<AppProductFunder>> Handle(GetAppProductFundersByAppIDQuery request, CancellationToken cancellationToken)
    {
        var response = await base.DbContext.Connection.ExecuteQueryAsync<AppProductFunder>("EXEC sp_appGetProductFunderID @UserId, @AppId",
        new
        {
            UserId = request.UserId,
            AppId = request.AppId
        });

        if (response == null)
            return new List<AppProductFunder>();
        else
            return response.ToList();
    }
}

