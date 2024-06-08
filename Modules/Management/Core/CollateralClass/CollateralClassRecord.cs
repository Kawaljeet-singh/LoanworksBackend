using System.ComponentModel.DataAnnotations;
using RepoDb.Attributes;

namespace LoanworksBackend.Modules.Management.Core.CollateralClass;

public class CollateralClassRecord
{
    [Key]
    public int Id { get; set; } 
    public int iApplicationClassID { get; set; }
    public int iCollateralCLassID { get; set; }
    public string cName { get; set; }= default!;
   
}
