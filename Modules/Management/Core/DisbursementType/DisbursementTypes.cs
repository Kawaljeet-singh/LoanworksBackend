using RepoDb.Attributes;
using System.ComponentModel.DataAnnotations;

namespace LoanworksBackend.Modules.Management.Core.DisbursementType;

public class DisbursementTypes
{
    [Key]
    [Map("id")]
    public int Id { get; set; }
    [Map("disbursementTypeDescription")]
    public string? DisbursementTypeDescription { get; set; }
}

