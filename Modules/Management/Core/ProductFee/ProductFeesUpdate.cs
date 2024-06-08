using System.ComponentModel.DataAnnotations;
using RepoDb.Attributes;

namespace LoanworksBackend.Modules.Management.Core.ProductFee;

public class ProductFeesUpdate
{
    [Map("productId")]
    public int ProductId { get; set; }
    [Map("feeId")]
    public int FeeId { get; set; }
    [Map("feeValue")]
    public decimal FeeValue { get; set; }
}
