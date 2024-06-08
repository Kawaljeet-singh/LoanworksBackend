using LoanworksBackend.Dal;
using LoanworksBackend.Modules.Applications.Core.FeeExceptions;
using MediatR;
using RepoDb;

namespace LoanworksBackend.Modules.Applications.Query.FeeExceptions;

public class GetFeeExceptionsByAppIDQuery : IRequest<List<FeeException>>
{
    public int AppId { get; set; } = default!;
    public int LegalCode { get; set; }
    public int ValuationCode { get; set; }
}
public class GetFeeExceptionsByAppIDQueryHandler : LosDbQueryHandler, IRequestHandler<GetFeeExceptionsByAppIDQuery, List<FeeException>>
{
    public GetFeeExceptionsByAppIDQueryHandler(IDbContext dbContext) : base(dbContext)
    {

    }
    public async Task<List<FeeException>> Handle(GetFeeExceptionsByAppIDQuery request, CancellationToken cancellationToken)
    {
        var response = await base.DbContext.Connection.ExecuteQueryAsync<FeeException>("EXEC sp_FeeExceptionsByAppID @AppId,@LegalCode,@ValuationCode",
            new
            {
                AppId = request.AppId,
                LegalCode = request.LegalCode,
                ValuationCode = request.ValuationCode
            });

        if (response == null)
            return new List<FeeException>();
        else
            return response.ToList();
    }
}
