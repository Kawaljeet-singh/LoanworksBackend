using LoanworksBackend.Dal;
using LoanworksBackend.Modules.Applications.Core.ApplicationLiabilities;
using MediatR;
using RepoDb;

namespace LoanworksBackend.Modules.Applications.Commands.ApplicationLiabilities;
public class DeleteAppLiabilitiesCommand : IRequest<int>
{
    public int LiabilityId { get; set; }
}
public class DeleteAppLiabilitiesCommandHandler : LosDbQueryHandler, IRequestHandler<DeleteAppLiabilitiesCommand, int>
{
    public DeleteAppLiabilitiesCommandHandler(IDbContext dbContext) : base(dbContext)
    {

    }
    public async Task<int> Handle(DeleteAppLiabilitiesCommand request, CancellationToken cancellationToken)
    {      
       var response = await base.DbContext.Connection.DeleteAsync<ApplicationLiability>(a => a.LiabilityId == request.LiabilityId);

        if (response == 0)
            return 0;
        else
            return response;
    }
}


