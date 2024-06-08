using RepoDb.Attributes;
using System.ComponentModel.DataAnnotations;

namespace LoanworksBackend.Modules.Management.Core.LoanPurposeClass;

public class LoanPurpose
{
    [Key]
    [Map("id")]
    public int Id { get; set; }
    [Map("loanPurpose")]
    public string? LoanPurposeName { get; set; } = default!;
}

