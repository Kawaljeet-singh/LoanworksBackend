using RepoDb.Attributes;
using System.ComponentModel.DataAnnotations;

namespace LoanworksBackend.Modules.Management.Core.Funds;

public class FundsPosition
{
    [Key]
    [Map("id")]
    public int Id { get; set; }
    public int FundsPositionId { get; set; }
    public string FundsPositionName { get; set; } = default!;
    public int FundsPositionTypeId { get; set; }
    public string? FundsPositionTypeName { get; set; }
    public string? FundsPositionCode { get; set; }
    public bool? Status { get; set; }
    public bool? AllowCapitalised { get; set; }
    public int HardCodedId { get; set; }
    [Map("FundsVerificationRequired")]
    public int FundsVerificationRequiredId { get; set; }
    public int PersonalLoanId { get; set; }
    public int AssetTypeId { get; set; }
    [Map("cLixiCode")]
    public string? LixiCode { get; set; }
    public int ApplicationClassId { get; set; }
}
