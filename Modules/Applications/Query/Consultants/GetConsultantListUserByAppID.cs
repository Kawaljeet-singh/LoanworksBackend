using LoanworksBackend.Dal;
using LoanworksBackend.Modules.Applications.Core.Consultants;
using MediatR;
using RepoDb;

namespace LoanworksBackend.Modules.Applications.Query.Consultants;

public class GetConsultantListUserByAppIDQuery : IRequest<List<RoleConsultant>>
{
    public int UserId { get; set; }
    public int AppId { get; set; }
}
public class GetConsultantListUserByAppIDQueryHandler : LosDbQueryHandler, IRequestHandler<GetConsultantListUserByAppIDQuery, List<RoleConsultant>>
{
    public GetConsultantListUserByAppIDQueryHandler(IDbContext dbContext) : base(dbContext)
    {

    }
    public async Task<List<RoleConsultant>> Handle(GetConsultantListUserByAppIDQuery request, CancellationToken cancellationToken)
    {
        var response = await base.DbContext.Connection.ExecuteQueryAsync<RoleConsultant>("EXEC USP_Roles_GetConsultantListUser @UserId, @AppId",
        new
        {
            UserId = request.UserId,
            AppId = request.AppId
        });

        if (response == null)
            return new List<RoleConsultant>();
        else
            return response.ToList();
    }
}


