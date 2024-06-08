using RepoDb.Attributes;

namespace LoanworksBackend.Modules.Management.Core.LoanPurposeClass;

public class InsertLoanPurpose
{
    [Map("loanPurpose")]
    public string? LoanPurposeName { get; set; } = default!;
}

