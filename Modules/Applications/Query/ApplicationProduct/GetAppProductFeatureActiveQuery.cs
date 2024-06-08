using LoanworksBackend.Dal;
using LoanworksBackend.Modules.Applications.Core.ApplicationProduct;
using MediatR;
using RepoDb;

namespace LoanworksBackend.Modules.Applications.Query.ApplicationProduct;

public class GetAppProductFeatureActiveQuery : IRequest<List<AppProductFeature>>
{
    public int ProductId { get; set; } = default!;
    public int AppProductId { get; set; } = default!;
}
public class GetProductFeatureActiveQueryHandler : LosDbQueryHandler, IRequestHandler<GetAppProductFeatureActiveQuery, List<AppProductFeature>>
{
    public GetProductFeatureActiveQueryHandler(IDbContext dbContext) : base(dbContext)
    {

    }
    public async Task<List<AppProductFeature>> Handle(GetAppProductFeatureActiveQuery request, CancellationToken cancellationToken)
    {
        var response = await base.DbContext.Connection.ExecuteQueryAsync<AppProductFeature>("EXEC USP_ProductFeature_Active_Get @ProductId,@AppProductId", new { ProductId = request.ProductId,AppProductId = request.AppProductId  });

        if (response == null)
            return new List<AppProductFeature>();
        else
            return response.ToList();
    }
}



