using RepoDb.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoanworksBackend.Modules.Applications.Core.Collateral_RealEstate;

public class InsertCollateralRealEstate
{
    [Map("appId")]
    public int? AppId { get; set; }
    [Map("propertyTypeId")]
    public int? PropertyTypeId { get; set; }
    [Display(Name = "PurchasePrice")]
    [Column(TypeName = "decimal(19, 2)")]
    [Map("purchasePrice")]
    public decimal PurchasePrice { get; set; }
    [Display(Name = "EstimatedValue")]
    [Column(TypeName = "decimal(19, 2)")]
    [Map("estimatedValue")]
    public decimal EstimatedValue { get; set; }
    [Display(Name = "Valuation")]
    [Column(TypeName = "decimal(19, 2)")]
    [Map("valuation")]
    public decimal Valuation { get; set; }
    [Display(Name = "LegalFees")]
    [Column(TypeName = "decimal(19, 2)")]
    [Map("legalFees")]
    public decimal LegalFees { get; set; }
    [Map("capitalized")]
    public bool? Capitalized { get; set; }
    [Map("securityAddress")]
    public string? SecurityAddress { get; set; }
}

