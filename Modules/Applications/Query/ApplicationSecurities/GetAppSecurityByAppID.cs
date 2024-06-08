using LoanworksBackend.Dal;
using LoanworksBackend.Modules.Applications.Core.ApplicationSecurities;
using MediatR;
using RepoDb;

namespace LoanworksBackend.Modules.Applications.Query.ApplicationSecurities;

public class GetAppSecurityByAppIDQuery : IRequest<List<ApplicationSecurity>>
{
    public int AppId { get; set; }
}
public class GetAppSecurityByAppIDQueryHandler : LosDbQueryHandler, IRequestHandler<GetAppSecurityByAppIDQuery, List<ApplicationSecurity>>
{
    public GetAppSecurityByAppIDQueryHandler(IDbContext dbContext) : base(dbContext)
    {

    }
    public async Task<List<ApplicationSecurity>> Handle(GetAppSecurityByAppIDQuery request, CancellationToken cancellationToken)
    {
        var response = await base.DbContext.Connection.QueryAsync<ApplicationSecurity>(a => a.AppId == request.AppId);

        if (response == null)
            return new List<ApplicationSecurity>();
        else
            return response.ToList();
    }
}


