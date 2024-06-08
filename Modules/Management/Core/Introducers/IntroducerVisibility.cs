using RepoDb.Attributes;
using System.ComponentModel.DataAnnotations;

namespace LoanworksBackend.Modules.Management.Core.Introducers;

public class IntroducerVisibility
{
    [Key]
    [Map("id")]
    public int Id { get; set; }
    [Map("iIntroducerVisibilityItemID")]
    public int? IntroducerVisibilityItemID { get; set; }
    [Map("cVisibilityStatus")]
    public string? VisibilityStatus { get; set; }
    [Map("cDescription")]
    public string? Description { get; set; }
    [Map("bAvailable")]
    public byte Available { get; set; }
    [Map("dTimeStamp")]
    public DateTime TimeStamp { get; set; }
}

