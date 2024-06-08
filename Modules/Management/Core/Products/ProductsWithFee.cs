using RepoDb.Attributes;

namespace LoanworksBackend.Modules.Management.Core.Products;

public class ProductsWithFee : ProductsConfigSummary
{
    [Map("cFeeName")]
    public string? FeeName { get; set; }
    [Map("fAmount")]
    public double FeeAmount { get; set; }
    public string? FeeValueType { get; set; }
}
