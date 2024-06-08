using RepoDb.Attributes;

namespace LoanworksBackend.Modules.Management.Core.Brand;

public class InsertBrands
{
    [Map("brandDescription")]
    public string? BrandDescription { get; set; }
}

