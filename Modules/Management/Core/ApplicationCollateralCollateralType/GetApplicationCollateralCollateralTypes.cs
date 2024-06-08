using System.ComponentModel.DataAnnotations;
using RepoDb.Attributes;

namespace LoanworksBackend.Modules.Management.Core.ApplicationCollateralCollateralType;

public class GetApplicationCollateralCollateralTypes
{
   
    public int CollateralTypeID { get; set; }
    
    public string CollateralTypeName { get; set; }= default!;

    public bool isChecked { get; set; }
   
}
