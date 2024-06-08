using LoanworksBackend.Dal;
using LoanworksBackend.Modules.Management.Core.Application_Loan;
using MediatR;
using RepoDb;

namespace LoanworksBackend.Modules.Management.Commands.Management;

public class DeleteApplicationLoanClassCommand: IRequest<List<DeleteApplicationLoanClass>>
{
     public int ApplicationClassID { get; set; }
}

public class DeleteApplicationLoanClassCommandHandler : LosDbQueryHandler, IRequestHandler<DeleteApplicationLoanClassCommand, List<DeleteApplicationLoanClass>>
{
    public DeleteApplicationLoanClassCommandHandler(IDbContext dbContext) : base(dbContext)
    {

    }

    public async Task<List<DeleteApplicationLoanClass>> Handle(DeleteApplicationLoanClassCommand request, CancellationToken cancellationToken)
    {
        var response = await base.DbContext.Connection.ExecuteQueryAsync<DeleteApplicationLoanClass>("EXEC sp_ApplicationClass_LoanClass_Delete_ByID " + request.ApplicationClassID );

        if (response == null)
            return new List<DeleteApplicationLoanClass>();
        else
            return response.ToList();
    }
}
