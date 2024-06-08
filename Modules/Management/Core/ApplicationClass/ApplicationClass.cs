using System.ComponentModel.DataAnnotations;
using RepoDb.Attributes;

namespace LoanworksBackend.Modules.Management.Core.ApplicationClass;

public class ApplicationClass
{
    [Key]
    [Map("iID")]
    public int? Id { get; set; } 
    [Map("cName")]
    public string Name { get; set; }= default!;
    [Map("bStatus")]
    public bool? Status { get; set; }
    [Map("iFeeType")]
    public int? FeeType { get; set; }   
}