using RepoDb.Attributes;
using System.ComponentModel.DataAnnotations;

namespace LoanworksBackend.Modules.Applications.Core.ApplicationProduct;

public class AppProductFees
{
    [Map("iAppID")]
    [Required]
    public int AppId { get; set; } = default;
    [Map("iAppProductID")]
    [Required]
    public int AppProductId { get; set; } = default;  
    [Map("iProdID")]
    public int? ProdId { get; set; }
    [Map("cAPProductName")]
    public string? APProductName { get; set; }
    [Map("fAPAmount")]
    public float? ApAmount { get; set; }
    [Map("iProdIDFees")]
    public int? ProdIDFees { get; set; }
    [Map("fAmount")]
    public float? Amount { get; set; }
    [Map("cFeeName")]
    public string? FeeName { get; set; }
    [Map("iFeeValueType")]
    public int? FeeValueType { get; set; }
    [Map("iBankTransactionType")]
    public int? BankTransactionType { get; set; }
    [Map("bIncludeinException")]
    public byte IncludeinException { get; set; }
    [Map("cGLAccount")]
    public string? GLAccount { get; set; }
    [Map("iAppCostID")]
    public int AppCostId { get; set; } = default;
    [Map("bCapitalized")]
    [Required]
    public bool Capitalized { get; set; }
    [Map("bAllowCapitalized")]
    [Required]
    public bool AllowCapitalized { get; set; }
}

