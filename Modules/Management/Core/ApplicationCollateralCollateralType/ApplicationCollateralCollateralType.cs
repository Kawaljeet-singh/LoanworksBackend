using System.ComponentModel.DataAnnotations;
using RepoDb.Attributes;

namespace LoanworksBackend.Modules.Management.Core.ApplicationCollateralCollateralType;

public class ApplicationCollateralCollateralType
{
    [Key]
    [Map("iID")] 
    public int? Id { get; set; } 

    [Map("iCollateralClassID")] 
    public int CollateralClassID { get; set; }
    
    public string CollateralClassName { get; set; }= default!;

    [Map("iCollateralTypeID")] 
    public int CollateralTypeID { get; set; }

    public string CollateralTypeName { get; set; }= default!;
    public bool isChecked { get;set;}
    public int collateralCount { get;set;}
   
}
