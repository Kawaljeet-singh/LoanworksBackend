using LoanworksBackend.Dal;
using LoanworksBackend.Modules.Management.Core.Application_Loan;
using MediatR;
using RepoDb;

namespace LoanworksBackend.Modules.Management.Commands.Management;

public class InsertApplicationLoanClassCommand: IRequest<List<ApplicationLoanClassInsert>>
{
    public ApplicationLoanClassInsert AppLoanClassInsert { get;set;}= default!;
}

public class InsertApplicationLoanClassCommandHandler : LosDbQueryHandler, IRequestHandler<InsertApplicationLoanClassCommand, List<ApplicationLoanClassInsert>>
{
    public InsertApplicationLoanClassCommandHandler(IDbContext dbContext) : base(dbContext)
    {

    }

    public async Task<List<ApplicationLoanClassInsert>> Handle(InsertApplicationLoanClassCommand request, CancellationToken cancellationToken)
    {
        var response = await base.DbContext.Connection.ExecuteQueryAsync<ApplicationLoanClassInsert>("EXEC sp_ApplicationClass_LoanClass_Insert " + request.AppLoanClassInsert.ApplicationClassID + " , '" + request.AppLoanClassInsert.LoanClassID  + "'");

        if (response == null)
            return new List<ApplicationLoanClassInsert>();
        else
            return response.ToList();
    }
}
