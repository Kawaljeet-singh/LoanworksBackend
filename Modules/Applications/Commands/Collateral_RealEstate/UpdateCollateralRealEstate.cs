using LoanworksBackend.Dal;
using LoanworksBackend.Modules.Applications.Core.Collateral_RealEstate;
using MediatR;
using RepoDb;

namespace LoanworksBackend.Modules.Applications.Commands.Collateral_RealEstate;

public class UpdateCollateralRealEstateCommand : IRequest<List<UpdateCollateralRealEstate>>
{
    public UpdateCollateralRealEstate UpdateCollateralRealEstate { get; set; } = default!;
}
public class UpdateCollateralRealEstateCommandHandler : LosDbQueryHandler, IRequestHandler<UpdateCollateralRealEstateCommand, List<UpdateCollateralRealEstate>>
{
    public UpdateCollateralRealEstateCommandHandler(IDbContext dbContext) : base(dbContext)
    {

    }
    public async Task<List<UpdateCollateralRealEstate>> Handle(UpdateCollateralRealEstateCommand request, CancellationToken cancellationToken)
    {
        var response = await base.DbContext.Connection.ExecuteQueryAsync<UpdateCollateralRealEstate>("EXEC sp_Collateral_RealEstate_Update @AppId,@PropertyTypeId,@PurchasePrice,@EstimatedValue,@Valuation,@LegalFees,@Capitalized,@SecurityAddress",
            new
            {
                AppId = request.UpdateCollateralRealEstate.AppId,
                PropertyTypeId = request.UpdateCollateralRealEstate.PropertyTypeId,
                PurchasePrice = request.UpdateCollateralRealEstate.PurchasePrice,
                EstimatedValue = request.UpdateCollateralRealEstate.EstimatedValue,
                Valuation = request.UpdateCollateralRealEstate.Valuation,
                LegalFees = request.UpdateCollateralRealEstate.LegalFees,
                Capitalized = request.UpdateCollateralRealEstate.Capitalized,
                SecurityAddress = request.UpdateCollateralRealEstate.SecurityAddress

            });

        if (response == null)
            return new List<UpdateCollateralRealEstate>();
        else
            return response.ToList();
    }
}

