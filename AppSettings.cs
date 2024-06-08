namespace LoanworksBackend;

/// <summary>
/// App settings loaded from appsettings.json config files
/// </summary>
public class AppSettings
{
    public ConnectionStrings? ConnectionStrings { get; set; }
    public bool EnableHealthChecks { get; set; }
    public LosWebservice? LosWebservice { get; set; }
    public int DownloadUserId { get; set; }
}

public class LosWebservice
{
    public string Url { get; set; } = default!;
    public int TimeoutInSeconds { get; set; }
}

public class ConnectionStrings
{
    public string LosDb { get; set; } = default!;
}