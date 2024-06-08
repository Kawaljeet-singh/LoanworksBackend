using RepoDb.Attributes;

namespace LoanworksBackend.Modules.Management.Core.Products;

public class ProductsWithFeature : ProductsConfigSummary
{
    [Map("varAttributeCode")]
    public string AttributeCode { get; set; } = default!;
    [Map("varAttributeDescription")]
    public string AttributeDescription { get; set; }= default!;
    [Map("varFeatureCode")]
    public string FeatureCode { get; set; } = default!;
    [Map("varFeatureDescription")]
    public string FeatureDescription { get; set; } = default!;

}
