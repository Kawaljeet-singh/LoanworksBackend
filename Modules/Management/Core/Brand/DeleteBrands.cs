using RepoDb.Attributes;
using System.ComponentModel.DataAnnotations;

namespace LoanworksBackend.Modules.Management.Core.Brand;

public class DeleteBrands
{
    [Key]
    [Map("Id")]
    public int Id { get; set; }
}

