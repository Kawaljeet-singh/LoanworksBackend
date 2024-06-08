using System.ComponentModel.DataAnnotations;
using RepoDb.Attributes;

namespace LoanworksBackend.Modules.Management.Core.LoanClasses;

public class LoanClass
{
    [Key]
    [Map("iID")]
    public int Id { get; set; }
    [Map("cName")]
    public string Name { get; set; } = default!;
}
