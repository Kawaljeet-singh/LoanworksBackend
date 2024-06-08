using LoanworksBackend.Dal;
using LoanworksBackend.Modules.Applications.Core.Collateral_RealEstate;
using MediatR;
using RepoDb;

namespace LoanworksBackend.Modules.Applications.Commands.Collateral_RealEstate;

public class InsertCollateralRealEstateCommand : IRequest<List<InsertCollateralRealEstate>>
{
    public InsertCollateralRealEstate InsertCollateralRealEstate { get; set; } = default!;
}
public class InsertCollateralRealEstateCommandHandler : LosDbQueryHandler, IRequestHandler<InsertCollateralRealEstateCommand, List<InsertCollateralRealEstate>>
{
    public InsertCollateralRealEstateCommandHandler(IDbContext dbContext) : base(dbContext)
    {

    }
    public async Task<List<InsertCollateralRealEstate>> Handle(InsertCollateralRealEstateCommand request, CancellationToken cancellationToken)
    {
        var response = await base.DbContext.Connection.ExecuteQueryAsync<InsertCollateralRealEstate>("EXEC sp_Collateral_RealEstate_Insert @AppId,@PropertyTypeId,@PurchasePrice,@EstimatedValue,@Valuation,@LegalFees,@Capitalized,@SecurityAddress",
            new
            {
                AppId = request.InsertCollateralRealEstate.AppId,
                PropertyTypeId = request.InsertCollateralRealEstate.PropertyTypeId,
                PurchasePrice = request.InsertCollateralRealEstate.PurchasePrice,
                EstimatedValue = request.InsertCollateralRealEstate.EstimatedValue,
                Valuation = request.InsertCollateralRealEstate.Valuation,
                LegalFees = request.InsertCollateralRealEstate.LegalFees,
                Capitalized = request.InsertCollateralRealEstate.Capitalized,
                SecurityAddress = request.InsertCollateralRealEstate.SecurityAddress
            });

        if (response == null)
            return new List<InsertCollateralRealEstate>();
        else
            return response.ToList();
    }
}


