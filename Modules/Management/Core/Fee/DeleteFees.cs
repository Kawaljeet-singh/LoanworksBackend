using RepoDb.Attributes;
using System.ComponentModel.DataAnnotations;

namespace LoanworksBackend.Modules.Management.Core.Fee;

public class DeleteFees
{  
    [Key]
    [Map("iFeeID")]
    public int FeeID { get; set; } = default!;
}

