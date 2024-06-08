using Microsoft.Data.SqlClient;

namespace LoanworksBackend.Dal;

/// <summary>
/// Db context that contains SqlConnection object to be used by ORM
/// </summary>
public class LosDbContext : IDbContext, IDisposable
{
    private readonly SqlConnection _connection;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="connection"></param>
    public LosDbContext(SqlConnection connection)
    {
        _connection = connection;
    }

    public SqlConnection Connection => _connection;

    /// <summary>
    /// 
    /// </summary>
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="isDispose"></param>
    protected virtual void Dispose(bool isDispose)
    {
        if (isDispose)
        {
            if (_connection != null)
                _connection.Dispose();
        }
    }
}