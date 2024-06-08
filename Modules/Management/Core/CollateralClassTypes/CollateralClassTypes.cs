using System.ComponentModel.DataAnnotations;
using RepoDb.Attributes;

namespace LoanworksBackend.Modules.Management.Core.CollateralClassTypes;

public class CollateralClassTypes
{  
    [Key]
   public int Id { get; set; }
   public int CollateralClassID { get; set; }
   public int CollateralTypeID { get; set; }
   public string CollateralTypeName { get; set; } = default!;
   public bool isChecked { get; set; }
}
