using RepoDb.Attributes;
using System.ComponentModel.DataAnnotations;

namespace LoanworksBackend.Modules.Management.Core.Introducers;

public class IntroducerCategory
{
    [Map("iIntrodCat")]
    public int IntroducerCategoryId { get; set; }
    [Map("cIntrodDesc")]
    public string IntroducerCategoryDescription { get; set; } = default!;
    [Map("bIntrodIsEditable")]
    public byte IntrodIsEditable { get; set; }
    [Map("bIntrodIsVisible")]
    public byte IntrodIsVisible { get; set; }
    [Map("iIntroducerVisibilityItemID")]
    public int? IntroducerVisibilityItemID { get; set; }
    [Map("cVisibilityStatus")]
    public string? VisibilityStatus { get; set; }
    [Map("bAvailable")]
    public byte Available { get; set; }
}
