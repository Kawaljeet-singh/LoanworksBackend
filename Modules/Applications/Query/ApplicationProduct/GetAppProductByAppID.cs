using LoanworksBackend.Dal;
using LoanworksBackend.Modules.Applications.Core.ApplicationProduct;
using MediatR;
using RepoDb;

namespace LoanworksBackend.Modules.Applications.Query.ApplicationProduct;

public class GetAppProductByAppIDQuery : IRequest<List<AppProduct>>
{
    public int AppId { get; set; }
}
public class GetAppProductByAppIDQueryHandler : LosDbQueryHandler, IRequestHandler<GetAppProductByAppIDQuery, List<AppProduct>>
{
    public GetAppProductByAppIDQueryHandler(IDbContext dbContext) : base(dbContext)
    {

    }
    public async Task<List<AppProduct>> Handle(GetAppProductByAppIDQuery request, CancellationToken cancellationToken)
    {
        var response = await base.DbContext.Connection.QueryAsync<AppProduct>(a => a.AppId == request.AppId);

        if (response == null)
            return new List<AppProduct>();
        else
            return response.ToList();
    }
}


