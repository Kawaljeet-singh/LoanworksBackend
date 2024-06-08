using System.ComponentModel.DataAnnotations;
using RepoDb.Attributes;

namespace LoanworksBackend.Modules.Management.Core.CollateralClassTypes;

public class DeleteCollateralClassTypes
{  
   public int CollateralClassID { get; set; }
   public int CollateralTypeID { get; set; }
}
