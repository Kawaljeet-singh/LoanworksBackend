using LoanworksBackend.Dal;
using LoanworksBackend.Modules.Management.Core.ApplicationCollateralClass;
using MediatR;
using RepoDb;

namespace LoanworksBackend.Modules.Management.Commands.Management;

public class InsertApplicationCollateralClassCommand: IRequest<List<ApplicationCollateralClassInsert>>
{ 
     public ApplicationCollateralClassInsert ApplicationCollateralClass { get; set; }= default!;
   
}


public class InsertApplicationCollateralClassCommandHandler : LosDbQueryHandler, IRequestHandler<InsertApplicationCollateralClassCommand, List<ApplicationCollateralClassInsert>>
{
    public InsertApplicationCollateralClassCommandHandler(IDbContext dbContext) : base(dbContext)
    {

    }

    public async Task<List<ApplicationCollateralClassInsert>> Handle(InsertApplicationCollateralClassCommand request, CancellationToken cancellationToken)
    {
        var response = await base.DbContext.Connection.ExecuteQueryAsync<ApplicationCollateralClassInsert>("EXEC sp_ApplicationClass_CollateralClass_Insert " + request.ApplicationCollateralClass.ApplicationClassID + " , '" + request.ApplicationCollateralClass.CollateralClassID  + "'");

        if (response == null)
            return new List<ApplicationCollateralClassInsert>();
        else
            return response.ToList();
    }
}
