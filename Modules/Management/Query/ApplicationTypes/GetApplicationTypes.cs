using LoanworksBackend.Dal;
using LoanworksBackend.Modules.Management.Core.ApplicationTypes;
using MediatR;
using RepoDb;

namespace LoanworksBackend.Modules.Management.Query.Management;

public class GetApplicationTypesQuery : IRequest<List<ApplicationTypes>>
{
    public int Id { get; set; }
}

public class GetApplicationTypesQueryHandler : LosDbQueryHandler, IRequestHandler<GetApplicationTypesQuery, List<ApplicationTypes>>
{
    public GetApplicationTypesQueryHandler(IDbContext dbContext) : base(dbContext)
    {

    }

    public async Task<List<ApplicationTypes>> Handle(GetApplicationTypesQuery request, CancellationToken cancellationToken)
    {
        var response = await base.DbContext.Connection.ExecuteQueryAsync<ApplicationTypes>("EXEC sp_ApplicationClass_ApplicationType_Get " + request.Id);

        if (response == null)
            return new List<ApplicationTypes>();
        else
            return response.ToList();
    }
}
