using System.ComponentModel.DataAnnotations;
using RepoDb.Attributes;

namespace LoanworksBackend.Modules.Management.Core.Application_Loan;

public class ApplicationLoanClass
{
    [Key]
    [Map("iID")]
    public int Id { get; set; } 

    [Map("iApplicationClassID")]
    public int ApplicationClassID { get; set;}

    [Map("iLoanClassID")]
    public int LoanClassID { get; set; }
    [Map("cName")]
    public string Name { get; set; }= default!;

    [Map("biSChecked")]
    public bool isChecked { get; set; }
    
  
   
}
