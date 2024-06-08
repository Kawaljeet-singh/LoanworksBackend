using LoanworksBackend.Dal;
using LoanworksBackend.Modules.Applications.Core.ApplicationSolicitors;
using MediatR;
using RepoDb;

namespace LoanworksBackend.Modules.Applications.Query.ApplicationSolicitors;

public class GetAppSolicitorByAppIDQuery : IRequest<List<ApplicationSolicitor>>
{
    public int UserId { get; set; }
    public int AppId { get; set; }
}
public class GetAppSolicitorByAppIDQueryHandler : LosDbQueryHandler, IRequestHandler<GetAppSolicitorByAppIDQuery, List<ApplicationSolicitor>>
{
    public GetAppSolicitorByAppIDQueryHandler(IDbContext dbContext) : base(dbContext)
    {

    }
    public async Task<List<ApplicationSolicitor>> Handle(GetAppSolicitorByAppIDQuery request, CancellationToken cancellationToken)
    {
        var response = await base.DbContext.Connection.ExecuteQueryAsync<ApplicationSolicitor>("EXEC sp_appGetAppSolicitorDetails @UserId, @AppId",
        new
        {
            UserId = request.UserId,
            AppId = request.AppId
        });

        if (response == null)
            return new List<ApplicationSolicitor>();
        else
            return response.ToList();
    }
}

