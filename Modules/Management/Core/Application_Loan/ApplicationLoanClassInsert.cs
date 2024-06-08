using System.ComponentModel.DataAnnotations;
using RepoDb.Attributes;

namespace LoanworksBackend.Modules.Management.Core.Application_Loan;

public class ApplicationLoanClassInsert
{
    [Key]
    [Map("iApplicationClassID")]
    public int? ApplicationClassID { get; set; } 
    [Map("iLoanClassID")]
    public string? LoanClassID { get; set; }
   
    
  
   
}
