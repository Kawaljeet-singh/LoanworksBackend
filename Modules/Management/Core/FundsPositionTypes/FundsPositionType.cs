using RepoDb.Attributes;
using System.ComponentModel.DataAnnotations;

namespace LoanworksBackend.Modules.Management.Core.FundsPositionTypes;

public class FundsPositionType
{
    [Key]    
    public int Id { get; set; } 
    public string fundsPositionType { get; set; } = default!;
    
}
