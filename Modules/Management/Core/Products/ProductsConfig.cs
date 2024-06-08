namespace LoanworksBackend.Modules.Management.Core.Products;

public class ProductsConfig
{
    public List<ProductsWithFee> ProductFees { get; set; } = new List<ProductsWithFee>();
    public List<ProductsWithFeature> ProductFeatures { get; set; } = new List<ProductsWithFeature>();
}
