using RepoDb.Attributes;
using System.ComponentModel.DataAnnotations;

namespace LoanworksBackend.Modules.Applications.Core.ApplicationIncomes;

[Map("tblAppIncome")]
public class ApplicationIncome
{
    [Key]
    [Map("ID")]
    public int Id { get; set; }
    [Map("iIncomeID")]
    [Required]
    public int IncomeId { get; set; } = default;
    [Map("iBorrowerID")]
    [Required]
    public int BorrowerId { get; set; } = default;
    [Map("iIncomeType")]
    public int? IncomeType { get; set; }
    [Map("fAmount")]
    public float? Amount { get; set; }
    [Map("cDetails")]
    public string? Details { get; set; }
    [Map("iIncomeCat")]
    public int? IncomeCat { get; set; }
    [Map("iIncomePeriod")]
    public int? IncomePeriod { get; set; }
    [Map("dIncomeStartDate")]
    public DateTime? IncomeStartDate { get; set; }
    [Map("dIncomeEndDate")]
    public DateTime? IncomeEndDate { get; set; }
    [Map("cOccupation")]
    public string? Occupation { get; set; }
    [Map("cEmployer")]
    public string? Employer { get; set; }
    [Map("iEmploymentType")]
    public int? EmploymentType { get; set; }
    [Map("iIndustryType")]
    public int? IndustryType { get; set; }
    [Map("dEmpStartDate")]
    public DateTime? EmpStartDate { get; set; }
    [Map("dIncomeVerified")]
    public DateTime? IncomeVerified { get; set; }
    [Map("iVerifiedBy")]
    public int? VerifiedBy { get; set; }
    [Map("iSecSelfEmpType")]
    public int? SecSelfEmpType { get; set; }
    [Map("fNetAmount")]
    public float? NetAmount { get; set; }
    [Map("bDeclared")]
    public bool? Declared { get; set; }
    [Map("fAdjustment")]
    public float? Adjustment { get; set; }
    [Map("bSystemImported")]
    public bool? SystemImported { get; set; }
    [Map("fCorrection")]
    public float? Correction { get; set; }
    [Map("cReason")]
    public string? Reason { get; set; }
    [Map("iFinancialDataSource")]
    public int? FinancialDataSource { get; set; }
}

