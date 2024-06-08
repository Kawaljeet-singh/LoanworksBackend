using LoanworksBackend.Dal;
using LoanworksBackend.Modules.Applications.Core.ApplicationLoans;
using MediatR;
using RepoDb;

namespace LoanworksBackend.Modules.Applications.Commands.ApplicationLoans;

public class InsertApplicationLoanClassCommand : IRequest<List<ApplicationLoan>>
{
    public ApplicationLoan InsertApplicationLoanClass { get; set; } = default!;
}
public class InsertApplicationLoanClassCommandHandler : LosDbQueryHandler, IRequestHandler<InsertApplicationLoanClassCommand, List<Core.ApplicationLoans.ApplicationLoan>>
{
    public InsertApplicationLoanClassCommandHandler(IDbContext dbContext) : base(dbContext)
    {

    }
    public async Task<List<ApplicationLoan>> Handle(InsertApplicationLoanClassCommand request, CancellationToken cancellationToken)
    {
        var response = await base.DbContext.Connection.ExecuteQueryAsync<ApplicationLoan>("EXEC sp_Application_LoanClass_Insert @ApplicationId,@LoanClassId",
            new
            {
                ApplicationId = request.InsertApplicationLoanClass.ApplicationId,
                LoanClassId = request.InsertApplicationLoanClass.LoanClassId
            });

        if (response == null)
            return new List<ApplicationLoan>();
        else
            return response.ToList();
    }
}


