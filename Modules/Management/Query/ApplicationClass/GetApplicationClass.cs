using LoanworksBackend.Dal;
using LoanworksBackend.Modules.Management.Core.ApplicationClass;
using MediatR;
using RepoDb;

namespace LoanworksBackend.Modules.Management.Query.Management;

public class GetApplicationClassQuery : IRequest<List<ApplicationClass>>
{
    public int id { get; set; }
}

public class GetApplicationClassQueryHandler : LosDbQueryHandler, IRequestHandler<GetApplicationClassQuery, List<ApplicationClass>>
{
    public GetApplicationClassQueryHandler(IDbContext dbContext) : base(dbContext)
    {

    }

    public async Task<List<ApplicationClass>> Handle(GetApplicationClassQuery request, CancellationToken cancellationToken)
    {
        var response = await base.DbContext.Connection.ExecuteQueryAsync<ApplicationClass>("EXEC sp_ApplicationClass_Get_ByID " + request.id);

        if (response == null)
            return new List<ApplicationClass>();
        else
            return response.ToList();
    }
}
