using LoanworksBackend.Dal;
using LoanworksBackend.Modules.Applications.Core.RestructuredLoanAmountDetails;
using MediatR;
using RepoDb;

namespace LoanworksBackend.Modules.Applications.Query.RestructuredLoanAmountDetails;

public class GetAppRestructuredLoanAmountByAppIDQuery : IRequest<List<RestructuredLoanAmountDetail>>
{
    public int AppId { get; set; }
}
public class GetAppRestructuredLoanAmountByAppIDQueryHandler : LosDbQueryHandler, IRequestHandler<GetAppRestructuredLoanAmountByAppIDQuery, List<RestructuredLoanAmountDetail>>
{
    public GetAppRestructuredLoanAmountByAppIDQueryHandler(IDbContext dbContext) : base(dbContext)
    {

    }
    public async Task<List<RestructuredLoanAmountDetail>> Handle(GetAppRestructuredLoanAmountByAppIDQuery request, CancellationToken cancellationToken)
    {
        var response = await base.DbContext.Connection.ExecuteQueryAsync<RestructuredLoanAmountDetail>("EXEC USP_App_GetRestructuredLoanAmount_Calculation_Detail @AppId", new { AppId = request.AppId });

        if (response == null)
            return new List<RestructuredLoanAmountDetail>();
        else
            return response.ToList();
    }
}

