using System.ComponentModel.DataAnnotations;
using RepoDb.Attributes;

namespace LoanworksBackend.Modules.Management.Core.CollateralClassTypes;

public class InsertCollateralClassTypes
{  
   public int CollateralClassID { get; set; }
   public string CollateralTypeID { get; set; } =default!;
}
