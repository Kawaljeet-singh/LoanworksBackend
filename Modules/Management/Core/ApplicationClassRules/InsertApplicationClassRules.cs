using System.ComponentModel.DataAnnotations;
using System.Data;
using RepoDb.Attributes;

namespace LoanworksBackend.Modules.Management.Core.ApplicationClassRules;

public class InsertApplicationClassRules
{
    public int ApplicationClassID { get; set; }
    public string? BusinessRuleID { get; set; }
}