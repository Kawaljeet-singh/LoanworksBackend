using LoanworksBackend.Dal;
using LoanworksBackend.Modules.Management.Core.ApplicationClass;
using MediatR;
using RepoDb;

namespace LoanworksBackend.Modules.Management.Query.Management;

public class ListAllApplicationClassQuery: IRequest<List<ApplicationClassGetList>>
{
     
}

public class ListAllApplicationClassQueryHandler : LosDbQueryHandler, IRequestHandler<ListAllApplicationClassQuery, List<ApplicationClassGetList>>
{
    public ListAllApplicationClassQueryHandler(IDbContext dbContext) : base(dbContext)
    {

    }

    public async Task<List<ApplicationClassGetList>> Handle(ListAllApplicationClassQuery request, CancellationToken cancellationToken)
    {
        var response = await base.DbContext.Connection.ExecuteQueryAsync<ApplicationClassGetList>("EXEC sp_ApplicationClass_Get_List");

        if (response == null)
            return new List<ApplicationClassGetList>();
        else
            return response.ToList();
    }
}
