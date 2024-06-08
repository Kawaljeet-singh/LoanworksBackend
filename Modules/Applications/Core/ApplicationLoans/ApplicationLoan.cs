using RepoDb.Attributes;

namespace LoanworksBackend.Modules.Applications.Core.ApplicationLoans;

public class ApplicationLoan
{   
    [Map("applicationId")]
    public int? ApplicationId { get; set; }
    [Map("loanClassId")]
    public int? LoanClassId { get; set; }
}

