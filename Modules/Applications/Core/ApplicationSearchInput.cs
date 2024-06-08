namespace LoanworksBackend.Modules.Applications.Core;

public class ApplicationSearchInput
{
    public string LoanName { get; set; } = string.Empty;
    public int DealNumber { get; set; }
    public int FunderLoanNumber { get; set; }
}
