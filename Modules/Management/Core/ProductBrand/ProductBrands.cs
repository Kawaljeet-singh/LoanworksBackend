using RepoDb.Attributes;
using System.ComponentModel.DataAnnotations;

namespace LoanworksBackend.Modules.Management.Core.ProductBrand;

[Map("tblProductBrands")]
public class ProductBrands
{
    [Key]
    [Map("Id")]
    public int Id { get; set; }
    [Map("brandId")]
    public int? BrandId { get; set; }
    [Map("productId")]
    public int? ProductId { get; set; }
    [Map("brandDescription")]
    public string? BrandDescription { get; set; }
    [Map("productName")]
    public string? ProductName { get; set; }
    [Map("isChecked")]
    public bool Assigned { get; set; }
    public bool IsChecked { get;set;}
}

