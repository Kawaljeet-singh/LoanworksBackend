using System.ComponentModel.DataAnnotations;
using RepoDb.Attributes;

namespace LoanworksBackend.Modules.Management.Core.ApplicationTypes;

public class ApplicationTypes
{
    [Key]
    [Map("iApplicationClassID")]
    public int ApplicationClassID { get; set; } 
    [Map("iApplicationTypeID")]
    public int ApplicationTypeID { get; set; }

    public string ApplicationType { get; set; }= default!;
   
    public bool isChecked { get; set; }     
}
