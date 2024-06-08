using RepoDb.Attributes;
using System.ComponentModel.DataAnnotations;

namespace LoanworksBackend.Modules.Management.Core.LoyaltyProgramTypes;

[Map("tblLoyaltyProgramTypes")]
public class LoyaltyProgramType
{
    [Key]
    public int Id { get; set; }
    public string? LoyaltyProgramTypeName { get; set; }
}

