using System.ComponentModel.DataAnnotations;
using LoanworksBackend.Dal;
using LoanworksBackend.Modules.Management.Core.ApplicationClass;
using MediatR;
using RepoDb;

namespace LoanworksBackend.Modules.Management.Commands.Management;

public class InsertApplicationClassCommand: IRequest<List<ApplicationClass>>
{
   public ApplicationClass ApplicationClass { get; internal set; } = default!;
  
}

public class InsertApplicationClassCommandHandler : LosDbQueryHandler, IRequestHandler<InsertApplicationClassCommand, List<ApplicationClass>>
{
    public InsertApplicationClassCommandHandler(IDbContext dbContext) : base(dbContext)
    {

    }

    public async Task<List<ApplicationClass>> Handle(InsertApplicationClassCommand request, CancellationToken cancellationToken)
    {
        var response = await base.DbContext.Connection.ExecuteQueryAsync<ApplicationClass>("EXEC sp_ApplicationClass_Insert '" + request.ApplicationClass.Name  + "'");

        if (response == null)
            return new List<ApplicationClass>();
        else
            return response.ToList();
    }
}
