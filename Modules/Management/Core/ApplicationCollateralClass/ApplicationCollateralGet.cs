using RepoDb.Attributes;

namespace LoanworksBackend.Modules.Management.Core.ApplicationCollateralClass;

public class ApplicationCollateralGet
{  
    [Map("iApplicationClassID")]
    public int? ApplicationClassID { get; set; }
    [Map("iCollateralCLassID")]
    public int? CollateralClassID { get; set; }    
    public string? CollateralClassName { get; set; }= default!;
    public bool? IsChecked { get; set; }
    [Map("CollateralCount")]
    public int? CollateralCount { get; set; }
}