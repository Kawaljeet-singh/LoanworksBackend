using LoanworksBackend.Dal;
using LoanworksBackend.Modules.Management.Core.Application_Loan;
using MediatR;
using RepoDb;

namespace LoanworksBackend.Modules.Management.Query.Management;

public class GetApplicationLoanClassQuery: IRequest<List<ApplicationLoanClass>>
{
     public int ApplicationClassID { get; set; }
}

public class GetApplicationLoanClassQueryHandler : LosDbQueryHandler, IRequestHandler<GetApplicationLoanClassQuery, List<ApplicationLoanClass>>
{
    public GetApplicationLoanClassQueryHandler(IDbContext dbContext) : base(dbContext)
    {

    }

    public async Task<List<ApplicationLoanClass>> Handle(GetApplicationLoanClassQuery request, CancellationToken cancellationToken)
    {
        var response = await base.DbContext.Connection.ExecuteQueryAsync<ApplicationLoanClass>("EXEC sp_ApplicationClass_LoanClass_Get_ByID " + request.ApplicationClassID );

        if (response == null)
            return new List<ApplicationLoanClass>();
        else
            return response.ToList();
    }
}
