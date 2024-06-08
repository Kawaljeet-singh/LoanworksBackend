using RepoDb.Attributes;

namespace LoanworksBackend.Modules.Management.Core.ApplicationFee;

public class InsertApplicationFees
{ 
    [Map("feesId")]
    public int? FeesId { get; set; }
    [Map("applicationClassId")]
    public string? ApplicationClassId { get; set; }
}

