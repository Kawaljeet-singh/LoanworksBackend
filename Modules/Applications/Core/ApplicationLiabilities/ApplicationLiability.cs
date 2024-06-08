using RepoDb.Attributes;
using System.ComponentModel.DataAnnotations;

namespace LoanworksBackend.Modules.Applications.Core.ApplicationLiabilities;

[Map("tblAppLiability")]
public class ApplicationLiability
{
    [Key]
    [Map("ID")]
    public int Id { get; set; }
    [Map("iLiabilityID")]
    [Required]
    public int LiabilityId { get; set; } = default;
    [Map("iBorrowerID")]
    [Required]
    public int BorrowerId { get; set; } = default;
    [Map("iLiabilityType")]
    public int? LiabilityType { get; set; }
    [Map("fLiabilityAmount")]
    public float? LiabilityAmount { get; set; }
    [Map("fLiabilityPerMonth")]
    public float? LiabilityPerMonth { get; set; }
    [Map("fLiabilityOwing")]
    public float? LiabilityOwing { get; set; }
    [Map("cNotes")]
    public string? Notes { get; set; }
    [Map("iLiabilityCat")]
    public int? LiabilityCat { get; set; }
    [Map("cInstitution")]
    public string? Institution { get; set; }
    [Map("fInterestRate")]
    public float? InterestRate { get; set; }
    [Map("iRateType")]
    public int? RateType { get; set; }
    [Map("iLoanType")]
    public int? LoanType { get; set; }
    [Map("bPayoutOnSettle")]
    [Required]
    public bool PayoutOnSettle { get; set; }
    [Map("bIsinArrearsorOverLimit")]
    public byte IsinArrearsorOverLimit { get; set; }
    [Map("bIsAnyOverDuePayments")]
    public byte IsAnyOverDuePayments { get; set; }
    [Map("cBSB")]
    public string? BSB { get; set; }
    [Map("cAccountNumber")]
    public string? AccountNumber { get; set; }
    [Map("iVerficationType")]
    public int? VerficationType { get; set; }
    [Map("dStatementOpenDate")]
    public DateTime? StatementOpenDate { get; set; }
    [Map("dStatementCloseDate")]
    public DateTime? StatementCloseDate { get; set; }
    [Map("iContinousStatement")]
    public int? ContinousStatement { get; set; }
    [Map("iCurrentIntrimStatement")]
    public int? CurrentIntrimStatement { get; set; }
    [Map("cAccountName")]
    public string? AccountName { get; set; }
    [Map("dIntrimStatementOpenDate")]
    public DateTime? IntrimStatementOpenDate { get; set; }
    [Map("dIntrimStatementCloseDate")]
    public DateTime? IntrimStatementCloseDate { get; set; }
    [Map("iPayoutOnSettlement")]
    public int? PayoutOnSettlement { get; set; }
    [Map("fRefinanceCost")]
    public float? RefinanceCost { get; set; }
    [Map("fNewLimit")]
    public float? NewLimit { get; set; }
    [Map("fArrearsAmount")]
    public float? ArrearsAmount { get; set; }
    [Map("bDeclared")]
    public bool? Declared { get; set; }
    [Map("iLoanTermMonths")]
    public int? LoanTermMonths { get; set; }
    [Map("bInternalRefinance")]
    public byte InternalRefinance { get; set; }
    [Map("bLenderAssessmentRequired")]
    public bool? LenderAssessmentRequired { get; set; }
    [Map("cDescription")]
    public string? Description { get; set; }
    [Map("iIOTermMonths")]
    public int? IOTermMonths { get; set; }
    [Map("fAdjustment")]
    public float? Adjustment { get; set; }
    [Map("bSystemImported")]
    public bool? SystemImported { get; set; }
    [Map("fCorrection")]
    public float? Correction { get; set; }
    [Map("cReason")]
    public string? Reason { get; set; }
    [Map("iVerified")]
    public int? Verified { get; set; }
    [Map("bInterestDeductible")]
    public bool? InterestDeductible { get; set; }
    [Map("iFinancialDataSource")]
    public int? FinancialDataSource { get; set; }
}

