using RepoDb.Attributes;

namespace LoanworksBackend.Modules.Management.Core.ProductBrand;

public class InsertProductBrand
{
    [Map("productId")]
    public int? ProductId { get; set; }
    [Map("brandId")]
    public string? BrandId { get; set; }
}

