using RepoDb.Attributes;

namespace LoanworksBackend.Modules.Management.Core.LoanTypes;

public class InsertLoanType
{
    [Map("loanType")]
    public string? LoanTypeName { get; set; }
}

