using System.ComponentModel.DataAnnotations;
using LoanworksBackend.Dal;
using LoanworksBackend.Modules.Management.Core.ApplicationClass;
using MediatR;
using RepoDb;

namespace LoanworksBackend.Modules.Management.Commands.Management;

public class UpdateApplicationClassCommand: IRequest<List<ApplicationClass>>
{
   public ApplicationClass ApplicationClass { get; internal set; } = default!;
  
}

public class UpdateApplicationClassCommandHandler : LosDbQueryHandler, IRequestHandler<UpdateApplicationClassCommand, List<ApplicationClass>>
{
    public UpdateApplicationClassCommandHandler(IDbContext dbContext) : base(dbContext)
    {

    }

    public async Task<List<ApplicationClass>> Handle(UpdateApplicationClassCommand request, CancellationToken cancellationToken)
    {
        var response = await base.DbContext.Connection.ExecuteQueryAsync<ApplicationClass>("EXEC sp_ApplicationClass_Update_ByID " + request.ApplicationClass.Id  + ", '" + request.ApplicationClass.Name + "'," +  request.ApplicationClass.Status + "," + request.ApplicationClass.FeeType);

        if (response == null)
            return new List<ApplicationClass>();
        else
            return response.ToList();
    }
}
