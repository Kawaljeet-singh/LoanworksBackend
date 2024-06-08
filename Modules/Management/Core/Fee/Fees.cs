using RepoDb.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoanworksBackend.Modules.Management.Core.Fee;

public class Fees
{  
    [Key]
    [Map("ID")]
    public int Id { get; set; }
    public int FeeID { get; set; }  
    public string? FeeName { get; set; }
    public int? FeeValueTypeId { get; set; }
    public string? FeeValueTypeDescription { get; set; }
    [Display(Name = "DefaultValue")]
    [Column(TypeName = "decimal(19, 2)")]      
    public decimal DefaultValue { get; set; }
    public int? BankTransactionTypeId { get; set; }
    public string? BankTransactionTypeDescription { get; set; }
    public int? AvailabilityId { get; set; }
    public string? AvailabilityDescription { get; set; }
    public int? DisbursementTypeId { get; set; }
    public string? DisbursementTypeDescription { get; set; }   
    public string? VarAttributeCode { get; set; }
    [Map("bAllowCapitalized")]   
    public bool? AllowCapitalized { get; set; }
    [Map("bDefaultFee")]
    public bool? DefaultFee { get; set; }
    [Map("feeActivated")]    
    public bool? FeeActivated { get; set; }
    [Map("bActived")]
    public byte Activated { get; set; }
    [Map("iApplicability")]
    public int? Applicability { get; set; }
    [Map("applicationClassId")]
    public int? ApplicationClassId { get; set; }
}

