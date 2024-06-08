using System.ComponentModel.DataAnnotations;
using RepoDb.Attributes;

namespace LoanworksBackend.Modules.Management.Core.CollateralType;

public class CollateralType
{  
    
    [Map("iID")]
    [Key]
  
    public int Id { get; set; } 
    [Map("cName")]
    public string Name { get; set; }= default!;
   
}
