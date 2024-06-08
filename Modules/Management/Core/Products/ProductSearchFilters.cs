namespace LoanworksBackend.Modules.Management.Core.Products;

public class ProductSearchFilters
{   
    public int? LoanClassID { get; set; }
    public int? ProductGroupID { get; set; }
    public string? ProductName { get; set; } 
    public string? ProductCode { get; set; } 
    public string? Funder { get; set; } 
    public string? FunderProductName { get; set; } 
    public string? FunderProductCode { get; set; } 
    public bool? ProductStatus { get; set; }
    public bool? FunderStatus { get; set; }
}

