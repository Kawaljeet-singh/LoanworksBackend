using RepoDb.Attributes;
using System.ComponentModel.DataAnnotations;

namespace LoanworksBackend.Modules.Management.Core.ProductDetails;

public class DeleteProductDetails
{
    [Key]
    [Map("id")]
    public int Id { get; set; } = default!;
}

