using RepoDb.Attributes;

namespace LoanworksBackend.Modules.Management.Core.ApplicationFunds;

public class InsertApplicationFundsPosition
{
    [Map("fundsPositionId")]
    public int? FundsPositionId { get; set; }
    [Map("applicationClassId")]
    public string? ApplicationClassId { get; set; }
}

