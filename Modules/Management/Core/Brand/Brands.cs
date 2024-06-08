using RepoDb.Attributes;
using System.ComponentModel.DataAnnotations;

namespace LoanworksBackend.Modules.Management.Core.Brand;

public class Brands
{
    [Key]
    [Map("Id")]
    public int Id { get; set; }
    [Map("brandDescription")]
    public string? BrandDescription { get; set; }
}

