using LoanworksBackend.Dal;
using LoanworksBackend.Modules.Applications.Core.ApplicationLoans;
using MediatR;
using RepoDb;

namespace LoanworksBackend.Modules.Applications.Commands.ApplicationLoans;

public class DeleteApplicationLoanClassCommand : IRequest<List<ApplicationLoan>>
{
    public ApplicationLoan DeleteApplicationLoanClass { get; set; } = default!;
}
public class DeleteApplicationLoanClassCommandHandler : LosDbQueryHandler, IRequestHandler<DeleteApplicationLoanClassCommand, List<Core.ApplicationLoans.ApplicationLoan>>
{
    public DeleteApplicationLoanClassCommandHandler(IDbContext dbContext) : base(dbContext)
    {

    }
    public async Task<List<ApplicationLoan>> Handle(DeleteApplicationLoanClassCommand request, CancellationToken cancellationToken)
    {
        var response = await base.DbContext.Connection.ExecuteQueryAsync<ApplicationLoan>("EXEC sp_Application_LoanClass_Delete @ApplicationId,@LoanClassId",
            new
            {
                ApplicationId = request.DeleteApplicationLoanClass.ApplicationId,
                LoanClassId = request.DeleteApplicationLoanClass.LoanClassId
            });

        if (response == null)
            return new List<ApplicationLoan>();
        else
            return response.ToList();
    }
}



