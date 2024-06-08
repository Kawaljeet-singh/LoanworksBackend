using LoanworksBackend.Dal;
using LoanworksBackend.Modules.Management.Core.ApplicationCollateralClass;
using MediatR;
using RepoDb;

namespace LoanworksBackend.Modules.Management.Query.Management;

public class GetApplicationCollateralClassQuery: IRequest<List<ApplicationCollateralGet>>
{
     public int Id { get; set; }
}

public class GetApplicationCollateralClassQueryHandler : LosDbQueryHandler, IRequestHandler<GetApplicationCollateralClassQuery, List<ApplicationCollateralGet>>
{
    public GetApplicationCollateralClassQueryHandler(IDbContext dbContext) : base(dbContext)
    {

    }

    public async Task<List<ApplicationCollateralGet>> Handle(GetApplicationCollateralClassQuery request, CancellationToken cancellationToken)
    {
        var response = await base.DbContext.Connection.ExecuteQueryAsync<ApplicationCollateralGet>("EXEC sp_ApplicationClass_CollateralClass_GetByID " + request.Id);

        if (response == null)
            return new List<ApplicationCollateralGet>();
        else
            return response.ToList();
    }
}
