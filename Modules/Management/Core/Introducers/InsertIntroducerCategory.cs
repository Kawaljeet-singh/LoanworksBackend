using RepoDb.Attributes;

namespace LoanworksBackend.Modules.Management.Core.Introducers;

public class InsertIntroducerCategory
{
    [Map("cIntrodDesc")]
    public string IntroducerCategoryDescription { get; set; } = default!;
    [Map("bIntrodIsVisible")]
    public byte IntrodIsVisible { get; set; }
    [Map("iIntroducerVisibilityItemID")]
    public int? IntroducerVisibilityItemID { get; set; }
    [Map("applicationClassId")]
    public string? ApplicationClassId { get; set; }
}

