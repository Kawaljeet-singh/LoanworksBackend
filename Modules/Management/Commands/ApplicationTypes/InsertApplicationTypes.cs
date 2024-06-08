using LoanworksBackend.Dal;
using LoanworksBackend.Modules.Management.Core.ApplicationTypes;
using MediatR;
using RepoDb;

namespace LoanworksBackend.Modules.Management.Commands.Management;

public class InsertApplicationTypesCommand: IRequest<List<ApplicationTypesInsert>>
{
    public ApplicationTypesInsert  ApplicationTypesInsert { get;set;}= default!;
}

public class InsertApplicationTypesCommandHandler : LosDbQueryHandler, IRequestHandler<InsertApplicationTypesCommand, List<ApplicationTypesInsert>>
{
    public InsertApplicationTypesCommandHandler(IDbContext dbContext) : base(dbContext)
    {

    }

    public async Task<List<ApplicationTypesInsert>> Handle(InsertApplicationTypesCommand request, CancellationToken cancellationToken)
    {
        var response = await base.DbContext.Connection.ExecuteQueryAsync<ApplicationTypesInsert>("EXEC sp_ApplicationClass_ApplicationType_Insert " + request.ApplicationTypesInsert.ApplicationClassID + " , '" + request.ApplicationTypesInsert.ApplicationTypeID + "'" );

        if (response == null)
            return new List<ApplicationTypesInsert>();
        else
            return response.ToList();
    }
}
