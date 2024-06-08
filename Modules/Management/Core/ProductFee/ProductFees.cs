using System.ComponentModel.DataAnnotations;
using RepoDb.Attributes;

namespace LoanworksBackend.Modules.Management.Core.ProductFee;

public class ProductFees
{
    [Key]
    [Map("id")]
    public int Id { get; set; }
    [Map("feeId")]
    public int FeeId { get; set; }
    [Map("feeName")]
    public string FeeName { get; set; } = default!;
    [Map("defaultValue")]
    public decimal? DefaultValue { get; set; }
    [Map("feeValue")]
    public decimal? FeeValue { get; set; }
    [Map("feeValueTypeId")]
    public int? FeeValueTypeId { get; set; }
    [Map("FeeValueTypeDescription")]
    public string FeeValueTypeDescription { get; set; } = default!;
}
