namespace LoanworksBackend.Dal;

public class LosDbQueryHandler
{
    private readonly IDbContext _dbContext;

    public LosDbQueryHandler(IDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    protected IDbContext DbContext => _dbContext;
}
