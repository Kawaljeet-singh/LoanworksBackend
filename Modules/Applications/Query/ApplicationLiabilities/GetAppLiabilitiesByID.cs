using LoanworksBackend.Dal;
using LoanworksBackend.Modules.Applications.Core.ApplicationLiabilities;
using MediatR;
using RepoDb;

namespace LoanworksBackend.Modules.Applications.Query.ApplicationLiabilities;

public class GetAppLiabilitiesByIDQuery : IRequest<List<ApplicationLiability>>
{
    public int LiabilityId { get; set; }
}
public class GetAppLiabilitiesByIDQueryHandler : LosDbQueryHandler, IRequestHandler<GetAppLiabilitiesByIDQuery, List<ApplicationLiability>>
{
    public GetAppLiabilitiesByIDQueryHandler(IDbContext dbContext) : base(dbContext)
    {

    }
    public async Task<List<ApplicationLiability>> Handle(GetAppLiabilitiesByIDQuery request, CancellationToken cancellationToken)
    {
        var response = await base.DbContext.Connection.QueryAsync<ApplicationLiability>(a => a.LiabilityId == request.LiabilityId);

        if (response == null)
            return new List<ApplicationLiability>();
        else
            return response.ToList();
    }
}


