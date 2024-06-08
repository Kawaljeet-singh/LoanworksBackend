using System.ComponentModel.DataAnnotations;
using RepoDb.Attributes;

namespace LoanworksBackend.Modules.Management.Core.CollateralClassTypes;

public class GetCollateralClassTypes
{  

 
   public int CollateralClassID { get; set; }
   public bool Assigned { get; set; }
 
  
}
