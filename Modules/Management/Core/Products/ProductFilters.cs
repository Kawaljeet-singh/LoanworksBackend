using RepoDb.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoanworksBackend.Modules.Management.Core.Products;

public class ProductFilters
{
    public int? loanClassID {get;set; }
    public int? productGroupID { get; set; }
    public string productName { get; set; }  = default!;     
    public string productCode { get; set; } = default!;    
    public string funder { get; set; } = default!;
    public string funderProductName { get; set; } = default!;
    public string funderProductCode { get; set; } = default!;
    public bool? productStatus { get; set; }
    public bool? funderStatus { get; set; }
}

