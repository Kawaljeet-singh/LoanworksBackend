using LoanworksBackend.Dal;
using LoanworksBackend.Modules.Management.Core.ApplicationCollateralClass;
using MediatR;
using RepoDb;

namespace LoanworksBackend.Modules.Management.Commands.Management;

public class DeleteApplicationCollateralClassCommand: IRequest<List<ApplicationCollateralClass>>
{
     public int Id { get; set; }
}

public class DeleteApplicationCollateralClassCommandHandler : LosDbQueryHandler, IRequestHandler<DeleteApplicationCollateralClassCommand, List<ApplicationCollateralClass>>
{
    public DeleteApplicationCollateralClassCommandHandler(IDbContext dbContext) : base(dbContext)
    {

    }

    public async Task<List<ApplicationCollateralClass>> Handle(DeleteApplicationCollateralClassCommand request, CancellationToken cancellationToken)
    {
        var response = await base.DbContext.Connection.ExecuteQueryAsync<ApplicationCollateralClass>("EXEC sp_ApplicationClass_CollateralClass_Delete_ByID " + request.Id);

        if (response == null)
            return new List<ApplicationCollateralClass>();
        else
            return response.ToList();
    }
}
