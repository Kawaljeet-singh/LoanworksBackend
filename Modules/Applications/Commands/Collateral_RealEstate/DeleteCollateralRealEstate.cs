using LoanworksBackend.Dal;
using LoanworksBackend.Modules.Applications.Core.Collateral_RealEstate;
using MediatR;
using RepoDb;

namespace LoanworksBackend.Modules.Applications.Commands.Collateral_RealEstate;

public class DeleteCollateralRealEstateCommand :IRequest<List<CollateralRealEstate>>
{
    public int Id { get; set; }
}
public class DeleteCollateralRealEstateCommandHandler : LosDbQueryHandler, IRequestHandler<DeleteCollateralRealEstateCommand, List<CollateralRealEstate>>
{
    public DeleteCollateralRealEstateCommandHandler(IDbContext dbContext) : base(dbContext)
    {

    }
    public async Task<List<CollateralRealEstate>> Handle(DeleteCollateralRealEstateCommand request, CancellationToken cancellationToken)
    {
        var response = await base.DbContext.Connection.ExecuteQueryAsync<CollateralRealEstate>("EXEC sp_Collateral_RealEstate_DeleteById @Id", new { Id = request.Id });

        if (response == null)
            return new List<CollateralRealEstate>();
        else
            return response.ToList();
    }
}



