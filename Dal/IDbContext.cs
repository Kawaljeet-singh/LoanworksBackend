using Microsoft.Data.SqlClient;

namespace LoanworksBackend.Dal;

/// <summary>
/// Contract for the db contexts
/// </summary>
public interface IDbContext
{
    public SqlConnection Connection { get; }
}