using System.ComponentModel.DataAnnotations;
using RepoDb.Attributes;

namespace LoanworksBackend.Modules.Management.Core.ApplicationCollateralClass;

public class ApplicationCollateralClassInsert
{
   
    public int ApplicationClassID { get; set; }

    public string CollateralClassID { get; set; } =default!;
    
   
}
