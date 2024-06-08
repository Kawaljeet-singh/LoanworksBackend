using LoanworksBackend.Dal;
using LoanworksBackend.Modules.Applications.Core.ApplicationProduct;
using MediatR;
using RepoDb;

namespace LoanworksBackend.Modules.Applications.Query.ApplicationProduct;

public class GetAppProductFeesQuery : IRequest<List<AppProductFees>>
{
    public int AppId { get; set; } = default!;
    public int LegalCode { get; set; }
    public int ValuationCode { get; set; }
}
public class GetAppProductFeesQueryHandler : LosDbQueryHandler, IRequestHandler<GetAppProductFeesQuery, List<AppProductFees>>
{
    public GetAppProductFeesQueryHandler(IDbContext dbContext) : base(dbContext)
    {

    }
    public async Task<List<AppProductFees>> Handle(GetAppProductFeesQuery request, CancellationToken cancellationToken)
    {
        var response = await base.DbContext.Connection.ExecuteQueryAsync<AppProductFees>("EXEC sp_GetAppProductFees @AppId,@LegalCode,@ValuationCode",
            new
            {
                AppId = request.AppId,
                LegalCode = request.LegalCode,
                ValuationCode = request.ValuationCode
            });

        if (response == null)
            return new List<AppProductFees>();
        else
            return response.ToList();
    }
}



