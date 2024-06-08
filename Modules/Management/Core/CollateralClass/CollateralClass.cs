using System.ComponentModel.DataAnnotations;
using RepoDb.Attributes;

namespace LoanworksBackend.Modules.Management.Core.CollateralClass;

public class CollateralClass
{
    [Key]
    [Map("iID")]
    public int Id { get; set; } 
    [Map("cName")]
    public string Name { get; set; }= default!;

    public bool editable {get;set;}
   
}
