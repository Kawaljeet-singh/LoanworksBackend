using RepoDb.Attributes;
using System.ComponentModel.DataAnnotations;

namespace LoanworksBackend.Modules.Management.Core.IntroducerProfiles;

public class IntroducerProfile
{
    [Key]    
    public int id { get; set; } 
    [Map("iIntroducerProfileHeaderID")]
    public int introducerID { get; set; } 
    [Map("cIntroducerProfile")]
    public string IntroducerProfileDescription { get; set; } = default!;
    [Map("iFootPrint")]
    public int FootPrint {get;set;}
    [Map("dTimeStamp")]
    public DateTime TimeStamp { get; set; }
    [Map("iRegionID")]
    public int RegionID { get; set; }
    [Map("iBranchID")]
    public int BranchID { get; set; }
    
}
