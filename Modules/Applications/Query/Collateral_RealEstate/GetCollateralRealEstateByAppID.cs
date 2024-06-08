using LoanworksBackend.Dal;
using LoanworksBackend.Modules.Applications.Core.Collateral_RealEstate;
using MediatR;
using RepoDb;

namespace LoanworksBackend.Modules.Applications.Query.Collateral_RealEstate;

public class GetCollateralRealEstateByAppIDQuery : IRequest<List<CollateralRealEstate>>
{
    public int AppId { get; set; }
}
public class GetCollateralRealEstateByAppIDQueryHandler : LosDbQueryHandler, IRequestHandler<GetCollateralRealEstateByAppIDQuery, List<CollateralRealEstate>>
{
    public GetCollateralRealEstateByAppIDQueryHandler(IDbContext dbContext) : base(dbContext)
    {

    }
    public async Task<List<CollateralRealEstate>> Handle(GetCollateralRealEstateByAppIDQuery request, CancellationToken cancellationToken)
    {
        var response = await base.DbContext.Connection.ExecuteQueryAsync<CollateralRealEstate>("EXEC sp_Collateral_RealEstate_GetByAppId @AppId", new { AppId = request.AppId });

        if (response == null)
            return new List<CollateralRealEstate>();
        else
            return response.ToList();
    }
}


