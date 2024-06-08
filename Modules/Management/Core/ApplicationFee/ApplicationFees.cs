using RepoDb.Attributes;
using System.ComponentModel.DataAnnotations;

namespace LoanworksBackend.Modules.Management.Core.ApplicationFee;

public class ApplicationFees
{
    [Key]
    [Map("Id")]
    public int Id { get; set; }
    [Map("feesId")]
    public int? FeesId { get; set; }
    [Map("feeName")]
    public string? FeeName { get; set; }
    [Map("applicationClassId")]
    public int? ApplicationClassId { get; set; }
    [Map("cName")]
    public string? ApplicationClassName { get; set; }
    [Map("isChecked")]
    public bool Assigned { get; set; }
}

