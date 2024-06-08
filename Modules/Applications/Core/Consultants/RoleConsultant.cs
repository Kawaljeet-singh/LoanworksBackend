using RepoDb.Attributes;
using System.ComponentModel.DataAnnotations;

namespace LoanworksBackend.Modules.Applications.Core.Consultants;

public class RoleConsultant
{
    [Map("iUserID")]
    [Required]
    public int UserId { get; set; }
    public string? UserName { get; set; }
}
