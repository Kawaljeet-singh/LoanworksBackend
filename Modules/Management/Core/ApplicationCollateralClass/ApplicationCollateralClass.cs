using System.ComponentModel.DataAnnotations;
using RepoDb.Attributes;

namespace LoanworksBackend.Modules.Management.Core.ApplicationCollateralClass;

public class ApplicationCollateralClass
{
    [Key]
    [Map("iID")]
    public int Id { get; set; }    
    [Map("iApplicationClassID")] 
    public int ApplicationClassID { get; set; }
    [Map("iCollateralClassID")]
    public int CollateralClassID { get; set; }    
    public string ApplicationClassName {get;set;}= default!;
    public string CollateralClassName { get; set; }= default!;
    public bool IsChecked { get; set; }
}