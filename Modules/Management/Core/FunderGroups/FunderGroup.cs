using RepoDb.Attributes;
using System.ComponentModel.DataAnnotations;

namespace LoanworksBackend.Modules.Management.Core.FunderGroups;

public class FunderGroup
{
    [Key]
    [Map("id")]
    public int Id { get; set; }
    [Map("funderGroupName")]
    public string? FunderGroupName { get; set; }
}

