namespace LoanworksBackend.Modules.Management.Core.Products;

public class ProductsConfigSummary
{
    public string ProductName { get; set; } = default!;
    public string Financier { get; set; }= default!;
    public int Term { get; set; }
    public double MinLoan { get; set; }
    public double MaxLoan { get; set; }
    public double MaxDiscount { get; set; }
    public double BorRate { get; set; }
    public double DelRate { get; set; }
    public string ProductStatus { get; set; } = default!;
}
