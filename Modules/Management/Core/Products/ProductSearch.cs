namespace LoanworksBackend.Modules.Management.Core.Products;

public class ProductSearch
{
    public string ProductCode { get; set; } = default!;
    public string ProductName { get; set; } = default!;
    public string FunderProductCode { get; set; } = default!;
    public string FunderCode { get; set; } = default!;
    public string Financier { get; set; } = default!;
    public string FunderName { get; set; } = default!;
    public string BorRate { get; set; } = default!;
    public string DelRate { get; set; } = default!;
    public string ProductStatus { get; set; } = default!;
}