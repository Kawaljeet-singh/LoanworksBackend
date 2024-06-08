using System.ComponentModel.DataAnnotations;
using RepoDb.Attributes;

namespace LoanworksBackend.Modules.Management.Core.ApplicationTypes;

public class ApplicationTypesInsert
{
   
    public int ApplicationClassID { get; set; }

    public string ApplicationTypeID { get; set; } =default!;
    
   
}
