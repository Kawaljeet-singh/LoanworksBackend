using RepoDb.Attributes;
using System.ComponentModel.DataAnnotations;

namespace LoanworksBackend.Modules.Management.Core.FeeValueType;

public class FeeValueTypes
{
    [Key]
    [Map("id")]
    public int Id { get; set; }
    [Map("feeValueTypeDescription")]
    public string? FeeValueTypeDescription { get; set; }
}

