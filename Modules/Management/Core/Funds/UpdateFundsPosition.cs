using RepoDb.Attributes;
using System.ComponentModel.DataAnnotations;

namespace LoanworksBackend.Modules.Management.Core.Funds;

public class UpdateFundsPosition
{
    [Map("iFundsPositionID")]
    public int? FundsPositionId { get; set; }
    [Map("cFundsPosition")]
    public string? FundsPositionName { get; set; } = default!;
    [Map("iFundsPositionType")]
    public int FundsPositionTypeId { get; set; }
    [Map("cFundsPositionCode")]
    public string? FundsPositionCode { get; set; }
    [Map("iStatus")]
    public bool? Status { get; set; }
    [Map("iFootPrint")]
    public int UserId { get; set; }
    [Map("bAllowCapitalised")]
    public bool AllowCapitalised { get; set; }
    [Map("bHardCoded")]
    public int HardCodedId { get; set; }
    [Map("iFundsVerificationRequired")]
    public int FundsVerificationRequiredId { get; set; }
    [Map("iPersonalLoan")]
    public int PersonalLoanId { get; set; }
    [Map("iAssetType")]
    public int AssetTypeId { get; set; }
    [Map("cLixiCode")]
    public string? LixiCode { get; set; }
    [Map("applicationClassId")]
    public string? ApplicationClassId { get; set; }
}

