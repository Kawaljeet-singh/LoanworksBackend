using RepoDb.Attributes;

namespace LoanworksBackend.Modules.Management.Core.ProductFee;

public class InsertProductFees
{
    [Map("productId")]
    public int ProductId { get; set; }
    [Map("feeId")]
    public string? FeeId { get; set; }
}

