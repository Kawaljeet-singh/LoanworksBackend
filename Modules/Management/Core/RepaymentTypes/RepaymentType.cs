using RepoDb.Attributes;
using System.ComponentModel.DataAnnotations;

namespace LoanworksBackend.Modules.Management.Core.RepaymentTypes;

public class RepaymentType
{
    [Key]
    [Map("id")]
    public int Id { get; set; }  
    public string? Name { get; set; }
}

