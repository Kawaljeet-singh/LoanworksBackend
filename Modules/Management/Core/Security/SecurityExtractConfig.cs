namespace LoanworksBackend.Modules.Management.Core.Security;

/// <summary>
/// Contains roundup of the security extract entities for exporting
/// </summary>
public class SecurityExtractConfig
{
    public List<UserMenuSecurityExtract> UserMenuSecurityExtract { get; set; } = new List<UserMenuSecurityExtract>();
    public List<UserTaskAccessExtract> UserTaskAccessExtract { get; set; } = new List<UserTaskAccessExtract>();
    public List<ProfileTaskAccessExtract> ProfileTaskAccessExtract { get; set; } = new List<ProfileTaskAccessExtract>();
}
