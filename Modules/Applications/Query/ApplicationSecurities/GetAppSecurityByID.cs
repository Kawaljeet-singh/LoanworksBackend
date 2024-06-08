using LoanworksBackend.Dal;
using LoanworksBackend.Modules.Applications.Core.ApplicationSecurities;
using MediatR;
using RepoDb;

namespace LoanworksBackend.Modules.Applications.Query.ApplicationSecurities;

public class GetAppSecurityByIDQuery : IRequest<List<ApplicationSecurity>>
{
    public int SecurityId { get; set; }
}
public class GetAppSecurityByIDQueryHandler : LosDbQueryHandler, IRequestHandler<GetAppSecurityByIDQuery, List<ApplicationSecurity>>
{
    public GetAppSecurityByIDQueryHandler(IDbContext dbContext) : base(dbContext)
    {

    }
    public async Task<List<ApplicationSecurity>> Handle(GetAppSecurityByIDQuery request, CancellationToken cancellationToken)
    {
        var response = await base.DbContext.Connection.QueryAsync<ApplicationSecurity>(a => a.SecurityId == request.SecurityId);

        if (response == null)
            return new List<ApplicationSecurity>();
        else
            return response.ToList();
    }
}


