using LoanworksBackend.Dal;
using LoanworksBackend.Modules.Applications.Core.ApplicationProduct;
using MediatR;
using RepoDb;
using System.Data;

namespace LoanworksBackend.Modules.Applications.Query.ApplicationProduct;

public class GetAppProductByIDQuery : IRequest<List<AppProduct>>
{
    public int AppProductId { get; set; }
}
public class GetAppProductByIDQueryHandler : LosDbQueryHandler, IRequestHandler<GetAppProductByIDQuery, List<AppProduct>>
{
    public GetAppProductByIDQueryHandler(IDbContext dbContext) : base(dbContext)
    {

    }
    public async Task<List<AppProduct>> Handle(GetAppProductByIDQuery request, CancellationToken cancellationToken)
    {
        var response = await base.DbContext.Connection.QueryAsync<AppProduct>(a => a.AppProductId == request.AppProductId);

        if (response == null)
            return new List<AppProduct>();
        else
            return response.ToList();
    }
}



