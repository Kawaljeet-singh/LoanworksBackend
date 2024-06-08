using LoanworksBackend.Dal;
using LoanworksBackend.Modules.Management.Core.ApplicationTypes;
using MediatR;
using RepoDb;

namespace LoanworksBackend.Modules.Management.Commands.Management;

public class DeleteApplicationTypesCommand: IRequest<List<ApplicationTypesInsert>>
{
    public int  Id { get;set;}
}

public class DeleteApplicationTypesCommandHandler : LosDbQueryHandler, IRequestHandler<DeleteApplicationTypesCommand, List<ApplicationTypesInsert>>
{
    public DeleteApplicationTypesCommandHandler(IDbContext dbContext) : base(dbContext)
    {

    }

    public async Task<List<ApplicationTypesInsert>> Handle(DeleteApplicationTypesCommand request, CancellationToken cancellationToken)
    {
        var response = await base.DbContext.Connection.ExecuteQueryAsync<ApplicationTypesInsert>("EXEC sp_ApplicationClass_ApplicationType_Delete_ByID " + request.Id );

        if (response == null)
            return new List<ApplicationTypesInsert>();
        else
            return response.ToList();
    }
}
