using LoanworksBackend.Dal;
using LoanworksBackend.Modules.Applications.Core.ApplicationBorrowers;
using MediatR;
using RepoDb;

namespace LoanworksBackend.Modules.Applications.Query.ApplicationBorrowers;

public class GetAppBorrowerByIDQuery : IRequest<List<ApplicationBorrower>>
{
    public int BorrowerId { get; set; }
}
public class GetAppBorrowerByIDQueryHandler : LosDbQueryHandler, IRequestHandler<GetAppBorrowerByIDQuery, List<ApplicationBorrower>>
{
    public GetAppBorrowerByIDQueryHandler(IDbContext dbContext) : base(dbContext)
    {

    }
    public async Task<List<ApplicationBorrower>> Handle(GetAppBorrowerByIDQuery request, CancellationToken cancellationToken)
    {
        var response = await base.DbContext.Connection.QueryAsync<ApplicationBorrower>(a => a.BorrowerId  == request.BorrowerId);

        if (response == null)
            return new List<ApplicationBorrower>();
        else
            return response.ToList();
    }
}
