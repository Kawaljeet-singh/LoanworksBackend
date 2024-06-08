using RepoDb.Attributes;

namespace LoanworksBackend.Core;

public class UserSession
{
    public int Id { get; set; }
    [Map("iUserSessionID")]
    public int UserSessionId { get; set; }
    [Map("iUserID")]
    public int UserId { get; set; }
    [Map("iSessionID")]
    public bool SessionId { get; set; }
    [Map("bSessionStatus")]
    public int SessionStatus { get; set; }
    [Map("iEntityID")]
    public int EntityId { get; set; }
    public string LoginToken { get; set; } = string.Empty;
    public DateTime LoginTokenExpiryTime { get; set; }
    public int SessionTimeout { get; set; }
    public DateTime ApiTokenExpiryDate { get; set; }
}
