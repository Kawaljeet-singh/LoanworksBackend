using RepoDb.Attributes;
using System.ComponentModel.DataAnnotations;

namespace LoanworksBackend.Modules.Management.Core.ProductClasses;

[Map("tblProductClass")]
public class ProductClass
{
    [Key]
    [Map("id")]
    public int Id { get; set; }
    [Map("productClassName")]
    public string? ProductClassName { get; set; }
}

