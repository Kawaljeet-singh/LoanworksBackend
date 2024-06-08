using System.ComponentModel.DataAnnotations;
using RepoDb.Attributes;

namespace LoanworksBackend.Modules.CreditCard.Core.CreditCardApplication;

public class CreditCardApplicationGetList
{
    [Key]
    [Map("iID")]
    public int? Id { get; set; } 
    [Map("cName")]
    public string Name { get; set; }= default!;
    [Map("bStatus")]
    public bool? Status { get; set; }
    [Map("iFeeType")]
    public int? FeeType { get; set; }
    public int? LoanClassesCount { get; set; }
    public int? CollateralClassesCount { get; set; }
    public int? ApplicationTypesCount { get; set; }
    public bool? IsChecked {get;set;}   
}