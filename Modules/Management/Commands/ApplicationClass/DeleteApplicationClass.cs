using System.ComponentModel.DataAnnotations;
using LoanworksBackend.Dal;
using LoanworksBackend.Modules.Management.Core.ApplicationClass;
using MediatR;
using RepoDb;

namespace LoanworksBackend.Modules.Management.Commands.Management;

public class DeleteApplicationClassCommand: IRequest<List<ApplicationClass>>
{ 
   public int Id { get; internal set; }  
}

public class DeleteApplicationClassCommandHandler : LosDbQueryHandler, IRequestHandler<DeleteApplicationClassCommand, List<ApplicationClass>>
{
    public DeleteApplicationClassCommandHandler(IDbContext dbContext) : base(dbContext)
    {

    }

    public async Task<List<ApplicationClass>> Handle(DeleteApplicationClassCommand request, CancellationToken cancellationToken)
    {
        var response = await base.DbContext.Connection.ExecuteQueryAsync<ApplicationClass>("EXEC sp_ApplicationClass_Delete_ByID " + request.Id);

        if (response == null)
            return new List<ApplicationClass>();
        else
            return response.ToList();
    }
}
