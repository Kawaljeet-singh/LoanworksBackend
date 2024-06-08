using RepoDb.Attributes;

namespace LoanworksBackend.Modules.Applications.Core.RestructuredLoanAmountDetails;

public class RestructuredLoanAmountDetail
{
    [Map("fApborrowerrate")]
    public float? APBorrowerrate { get; set; }
    [Map("fApAmount")]
    public float? ApAmount { get; set; }
    [Map("cApProductType")]
    public string? APProductType { get; set; }
    [Map("iFrequency")]
    public int? Frequency { get; set; }
    [Map("fTerm")]
    public int? Term { get; set; }
}
