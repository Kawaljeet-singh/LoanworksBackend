using RepoDb.Attributes;
using System.ComponentModel.DataAnnotations;

namespace LoanworksBackend.Modules.Management.Core.ApplicationFunds;

public class ApplicationFundsPosition
{
    [Key]
    [Map("Id")]
    public int Id { get; set; }
    public int FundPositionId { get; set; }
    public string FundPositionName { get; set; } =default!;
    public int? ApplicationClassId { get; set; }
    public string? ApplicationClassName { get; set; }
    [Map("isChecked")]
    public bool Assigned { get; set; }
}

