using RepoDb.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoanworksBackend.Modules.Management.Core.Fee;

public class UpdateFees
{  
    [Map("iFeeID")]
    public int? FeeID { get; set; }
    [Map("cFeeName")]
    public string? FeeName { get; set; }
    [Map("bSystem")]
    public byte System { get; set; }
    [Map("iFeeValueType")]
    public int? FeeValueType { get; set; }
    [Map("iBankTransactionType")]
    public int? BankTransactionType { get; set; }
    [Map("iApplicability")]
    public int? Applicability { get; set; }
    [Map("bDefaultFee")]
    public bool? DefaultFee { get; set; }
    [Map("fDefaultValue")]
    public decimal DefaultValue { get; set; }
    [Map("bActived")]
    public byte Actived { get; set; }
    [Map("varAttributeCode")]
    public string? VarAttributeCode { get; set; }
    [Map("bAllowCapitalized ")]
    public bool? AllowCapitalized { get; set; }
    [Map("iDisbursementType ")]
    public int? DisbursementType { get; set; } 
    public int? Availability { get; set; }
    [Map("feeActivated")]
    public bool? FeeActivated { get; set; }
    [Map("applicationClassId")]
    public string? ApplicationClassId { get; set; }
}

