using LoanworksBackend.Dal;
using LoanworksBackend.Modules.Applications.Core;
using MediatR;
using Microsoft.Data.SqlClient;
using RepoDb;
using System.Data;

namespace LoanworksBackend.Modules.Applications.Query.Applications;

public class GetAppMainDetailsByAppIDQuery : IRequest<List<Application>>
{
    public int AppId { get; set; }
}
public class GetAppMainDetailsByAppIDQueryHandler : LosDbQueryHandler, IRequestHandler<GetAppMainDetailsByAppIDQuery, List<Application>>
{
    public GetAppMainDetailsByAppIDQueryHandler(IDbContext dbContext) : base(dbContext)
    {

    }
    public async Task<List<Application>> Handle(GetAppMainDetailsByAppIDQuery request, CancellationToken cancellationToken)
    {
        var response = await base.DbContext.Connection.QueryAsync<Application>(a => a.ApplicationId == request.AppId);

        if (response == null)
            return new List<Application>();
        else
            return response.ToList();
    }
}

