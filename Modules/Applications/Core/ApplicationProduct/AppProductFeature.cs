using RepoDb.Attributes;

namespace LoanworksBackend.Modules.Applications.Core.ApplicationProduct;

public class AppProductFeature
{
    [Map("varAttributeCode")]
    public string? VarAttributeCode { get; set; }
    [Map("varAttributeDescription")]
    public string? VarAttributeDescription { get; set; }
    [Map("bOptional")]
    public int? VarValueOptional { get; set; }
    [Map("bChecked")]
    public int? VarValueChecked { get; set; }
    [Map("iCtr")]
    public int? Ctr { get; set; }
    [Map("bMultiple")]
    public bool? Multiple { get; set; }
    [Map("iNextCtr")]
    public int? NextCtr { get; set; }
}


