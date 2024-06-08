using RepoDb.Attributes;

namespace LoanworksBackend.Modules.Management.Core.ProductBrand;

public class InsertProductBrands
{
    [Map("brandId")]  
    public int? BrandId { get; set; }
    [Map("productId")]
    public string? ProductId { get; set; }
}

