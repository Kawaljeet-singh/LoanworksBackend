using RepoDb.Attributes;
using System.ComponentModel.DataAnnotations;

namespace LoanworksBackend.Modules.Management.Core.LoanTypes;

[Map("tblLoanType")]
public class LoanType
{
    [Key]
    [Map("id")]
    public int Id { get; set; }
    [Map("loanType")]
    public string? LoanTypeName { get; set; }
}

