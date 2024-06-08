using RepoDb.Attributes;
using System.ComponentModel.DataAnnotations;

namespace LoanworksBackend.Modules.Management.Core.ProductGroups;

[Map("tblProductGroup")]
public class ProductGroup
{
    [Key]
    [Map("id")]
    public int Id { get; set; }
    public string? Name { get; set; }
}

