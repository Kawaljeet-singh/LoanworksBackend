using System.ComponentModel.DataAnnotations;
using RepoDb.Attributes;

namespace LoanworksBackend.Modules.Management.Core.CollateralClass;

public class UpdateCollateralClass
{
    public int? Id { get; set; }
    public string Name { get; set; }= default!;
   
}
