using RepoDb.Attributes;
using System.ComponentModel.DataAnnotations;

namespace LoanworksBackend.Modules.Applications.Core.AppStatus;

public class ApplicationStatus
{
    [Key]
    [Map("ID")]
    public int Id { get; set; }
    [Map("iAppStatusID")]
    [Required]
    public int AppStatusId { get; set; }
    [Map("iAppID")]
    [Required]
    public int AppId { get; set; }
    [Map("dCreated")]  
    public string Created { get; set; } = string.Empty;
    [Map("dLOISent")] 
    public string LOISent { get; set; } = string.Empty;
    [Map("dLOIReceived")]
    public string LOIReceived { get; set; } = string.Empty;
    [Map("dValSent")] 
    public string ValSent { get; set; } = string.Empty;
    [Map("dValReceived")]
    public string ValReceived { get; set; } = string.Empty;
    [Map("dMISent")]
    public string MISent { get; set; } = string.Empty;
    [Map("dMIRec")]  
    public string MIRec { get; set; } = string.Empty;
    [Map("dFundSent")]
    public string FundSent { get; set; } = string.Empty;
    [Map("dWithSolicitor")]
    public string WithSolicitor { get; set; } = string.Empty;
    [Map("dSettled")]
    public string Settled { get; set; } = string.Empty;
    [Map("dDischargedRefinanced")]
    public string DischargedRefinanced { get; set; } = string.Empty;
    [Map("dDischargedAssetSold")]
    public string DischargedAssetSold { get; set; } = string.Empty;
    [Map("dDischargedCash")]
    public string DischargedCash { get; set; } = string.Empty;
    [Map("dPayOut")]  
    public string PayOut { get; set; } = string.Empty;
    [Map("dIdenticalLoanDate")]
    public string IdenticalLoanDate { get; set; } = string.Empty;
    [Map("dRejectedbyMortgageManager")]
    public string RejectedbyMortgageManager { get; set; } = string.Empty;
    [Map("dRejectedbyFundsManager")] 
    public string RejectedbyFundsManager { get; set; } = string.Empty;
    [Map("dRejectedbyMortgageInsurer")]
    public string RejectedbyMortgageInsurer { get; set; } = string.Empty;
    [Map("dCancelledbyApplicant")]  
    public string CancelledbyApplicant { get; set; } = string.Empty;
    [Map("bAppLoacked")]
    public byte AppLoacked { get; set; }
    [Map("iFootPrint")]
    public int? FootPrint { get; set; }
    [Map("dApproved")]
    public string Approved { get; set; } = string.Empty;
    [Map("iReasonID")]
    public int? ReasonId { get; set; }
    [Map("fDischargeAmount")]
    public decimal DischargeAmount { get; set; }
    [Map("cNotes")]
    public string Notes { get; set; } = string.Empty;
    public int? IsIdenticalLoan { get; set; }
}
