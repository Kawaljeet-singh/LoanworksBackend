using System.ComponentModel.DataAnnotations;
using RepoDb.Attributes;

namespace LoanworksBackend.Modules.Management.Core.ApplicationClassRules;

public class ApplicationClassRules
{
    public int ApplicationClassID { get; set; } 
    public int BusinessRuleID { get; set; }    
    public string RuleName { get; set; }= default!;    
    public bool IsChecked { get; set; }   
}