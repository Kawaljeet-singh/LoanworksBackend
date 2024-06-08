using RepoDb.Attributes;

namespace LoanworksBackend.Modules.Applications.Core.AppProductFunders;

public class AppProductFunder
{  
    [Map("iFinancier")]
    public int? Financier { get; set; }
    [Map("cFinancier")]
    public string? FinancierName { get; set; }
}
