using LoanworksBackend.Dal;
using LoanworksBackend.Modules.Management.Core.ApplicationCollateralClass;
using MediatR;
using RepoDb;

namespace LoanworksBackend.Modules.Management.Query.Management;

public class ListAllApplicationCollateralClassQuery: IRequest<List<ApplicationCollateralClass>>
{
     
}

public class ListAllApplicationCollateralClassQueryHandler : LosDbQueryHandler, IRequestHandler<ListAllApplicationCollateralClassQuery, List<ApplicationCollateralClass>>
{
    public ListAllApplicationCollateralClassQueryHandler(IDbContext dbContext) : base(dbContext)
    {

    }

    public async Task<List<ApplicationCollateralClass>> Handle(ListAllApplicationCollateralClassQuery request, CancellationToken cancellationToken)
    {
        var response = await base.DbContext.Connection.ExecuteQueryAsync<ApplicationCollateralClass>("EXEC sp_ApplicationClass_CollateralClass_Get");

        if (response == null)
            return new List<ApplicationCollateralClass>();
        else
            return response.ToList();
    }
}
