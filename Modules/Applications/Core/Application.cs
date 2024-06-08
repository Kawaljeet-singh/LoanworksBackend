using RepoDb.Attributes;
using RepoDb.Attributes.Parameter;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoanworksBackend.Modules.Applications.Core;

[Map("tblAppMain")]
public class Application
{
    [Key]
    [Map("ID")]
    public int Id { get; set; }
    [Map("iAppID")]
    public int? ApplicationId { get; set; }
    [Map("iEnqID")]
    public int? EnqId { get; set; }
    [Map("cDealingID")]
    public string DealingId { get; set; } = string.Empty;
    [Map("iVariation")]
    public int? Variation { get; set; }
    [Map("dAppDate")]
    public DateTime? ApplicationDate { get; set; }
    [Map("cAccountNo")]
    public string AccountNo { get; set; } = string.Empty;
    [Map("cLoanName")]
    public string LoanName { get; set; } = string.Empty;
    [Map("iappstatus")]
    public int? ApplicationStatus { get; set; }
    [Map("iLoanPurpose")]
    public int? LoanPurpose { get; set; }
    [Map("iAppType")]
    public int? ApplicationType { get; set; }
    [Map("cConsultant")]
    public string Consultant { get; set; } = string.Empty;
    [Map("iAppOwner")]
    [Required]
    public int ApplicationOwner { get; set; }
    [Map("iPriority")]
    public byte Priority { get; set; }
    [Map("iNationalIntroducer")]
    public int? NationalIntroducer { get; set; }
    [Map("iBranchIntroducer")]
    public int? BranchIntroducer { get; set; }
    [Map("fPercentage")]
    public float? Percentage { get; set; }
    [Map("fSetFee")]
    public float? SetFee { get; set; }
    [Map("iCondition")]
    public int? Condition { get; set; }
    [Map("cNotes")]
    public string Notes { get; set; } = string.Empty;
    [Map("iFootPrint")]
    public int? FootPrint { get; set; }
    [Required]
    [Map("iBranchID")]
    public int BranchId { get; set; }
    [Required]
    [Map("iRegionID")]
    public int RegionId { get; set; }
    [Map("iOurSolicitorID")]
    public int? OurSolicitorId { get; set; }
    [Map("iRootAppID")]
    public int RootAppId { get; set; }
    [Map("iRootVariationID")]
    public int? RootVariationId { get; set; }
    [Map("ccondition")]
    public string ConditionName { get; set; } = string.Empty;
    [Map("dpropsettle")]
    public DateTime? PropSettle { get; set; }
    [Map("cLpurpose")]
    public string Lpurpose { get; set; } = string.Empty;
    [Map("iCheckList")]
    public int? CheckList { get; set; }
    [Map("fMortgageInsurerPremium")]
    public float? MortgageInsurerPremium { get; set; }
    [Map("iMortgageInsurer")]
    public int? MortgageInsurer { get; set; }
    [Map("cBackground")]
    public string Background { get; set; } = string.Empty;
    [Map("cCustomerID")]
    public string CustomerId { get; set; } = string.Empty;
    [Map("bExcludeFromCommission")]
    public byte ExcludeFromCommission { get; set; }
    [Map("bRegulated")]
    public byte Regulated { get; set; }
    [Map("iNumberOfCouples")]
    public int? NumberOfCouples { get; set; }
    [Display(Name = "MortgageInsurerStampDuty")]
    [Column(TypeName = "decimal(19, 2)")]
    [Map("fMortgageInsurerStampDuty")]
    public decimal MortgageInsurerStampDuty { get; set; }
    [Map("cMortgageInsurerPolicyNumber")]
    public string MortgageInsurerPolicyNumber { get; set; } = string.Empty;
    [Map("iConsultantID")]
    public int? ConsultantId { get; set; }
    [Map("cPreferredBranch")]
    public string PreferredBranch { get; set; } = string.Empty;
    [Map("cPreferredBsb")]
    public string PreferredBsb { get; set; } = string.Empty;
    [Map("bUnderWritingAuthority")]
    public byte UnderWritingAuthority { get; set; }
    [Map("dMortgageInsurerApprovalDate")]
    public DateTime? MortgageInsurerApprovalDate { get; set; }
    [Map("dMortgageInsurerPolicyDate")]
    public DateTime? MortgageInsurerPolicyDate { get; set; }
    [Map("iIntroducerProfileHeaderID")]
    public int? IntroducerProfileHeaderId { get; set; }
    [Map("iVariationType")]
    public int? VariationType { get; set; }
    [Map("iTitleInsuranceCompanyID")]
    public int? TitleInsuranceCompanyId { get; set; }
    [Map("cTitleInsurancePolicy")]
    public string TitleInsurancePolicy { get; set; } = string.Empty;
    [Map("dTitleInsuranceApprovedDate")]
    public DateTime? TitleInsuranceApprovedDate { get; set; }
    [Map("fTitleInsurancePaymentAmount")]
    public float? TitleInsurancePaymentAmount { get; set; }
    [Map("dTitleInsurancePaymentDate")]
    public DateTime? TitleInsurancePaymentDate { get; set; }
    [Map("cThridPartyLoanID1")]
    public string ThridPartyLoanID1 { get; set; } = string.Empty;
    [Map("cThridPartyLoanID2")]
    public string ThridPartyLoanID2 { get; set; } = string.Empty;
    [Map("iNumberOfHouseholds")]
    public int? NumberOfHouseholds { get; set; }
    [Map("fNSR")]
    public float? NSR { get; set; }
    [Map("fDSR")]
    public float? DSR { get; set; }
    [Map("fTotalRestructuredLoanAmount")]
    public float? TotalRestructuredLoanAmount { get; set; }
    [Map("fTotalRestructuredLoanRepayment")]
    public float? TotalRestructuredLoanRepayment { get; set; }
    [Map("bMortgageInsurancePremiumCapitalised")]
    public byte MortgageInsurancePremiumCapitalised { get; set; }
    [Map("dpropfinanceapproval")]
    public DateTime? PropFinanceApproval { get; set; }
    [Required]
    [Map("bMortgageInsRequired")]
    public bool MortgageInsRequired { get; set; }
    [Map("bPreGST")]
    public byte PreGST { get; set; }
    [Map("bIsBorrwerContactYouDirectly")]
    public byte IsBorrwerContactYouDirectly { get; set; }
    [Map("cBorrowerReferredBy")]
    public string BorrowerReferredBy { get; set; } = string.Empty;
    [Map("bIsBorrowerisActingonOwnorBehalf")]
    public byte IsBorrowerisActingonOwnorBehalf { get; set; }
    [Map("bIsDocumentSentToOriginator")]
    public byte IsDocumentSentToOriginator { get; set; }
    [Map("cExternalAppID")]
    public string ExternalAppId { get; set; } = string.Empty;
    [Map("iProgramType")]
    public int? ProgramType { get; set; }
    [Map("iProPack")]
    public int? ProPack { get; set; }
    [Map("fBaseLVR")]
    public float? BaseLVR { get; set; }
    [Map("fFinalLVR")]
    public float? FinalLVR { get; set; }
    [Map("fNDI")]
    public float? NDI { get; set; }
    [Map("fMortgageInsurerPremiumEst")]
    public float? MortgageInsurerPremiumEst { get; set; }
    [Map("fMortgageInsurerStampDutyEst")]
    public float? MortgageInsurerStampDutyEst { get; set; }
    [Map("cCreateSource")]
    public string CreateSource { get; set; } = string.Empty;
    [Map("dSettlementBookedDate")]
    public DateTime? SettlementBookedDate { get; set; }
    [Map("iAppClass")]
    public int? ApplicationClass { get; set; }
    [Map("bAllPartiesAgreeToElectronicSignature")]
    public bool? AllPartiesAgreeToElectronicSignature { get; set; }
    [Map("iMortgageInsurancePaidBy")]
    public int? MortgageInsurancePaidBy { get; set; }
    [Map("bMortgagePremiumRiskFeeCollected")]
    public byte MortgagePremiumRiskFeeCollected { get; set; }
    [Map("iSendMortgageDocumentsTo")]
    public int? SendMortgageDocumentsTo { get; set; }
    [Map("cMortgageDocumentsToAddress1")]
    public string MortgageDocumentsToAddress1 { get; set; } = string.Empty;
    [Map("cMortgageDocumentsToAddress2")]
    public string MortgageDocumentsToAddress2 { get; set; } = string.Empty;
    [Map("cMortgageDocumentsToSuburb")]
    public string MortgageDocumentsToSuburb { get; set; } = string.Empty;
    [Map("cMortgageDocumentsToPostcode")]
    public string MortgageDocumentsToPostcode { get; set; } = string.Empty;
    [Map("iMortgageDocumentsToState")]
    public int? MortgageDocumentsToState { get; set; }
    [Map("iMortgageDocumentsToCountry")]
    public int? MortgageDocumentsToCountry { get; set; }
    [Map("iParentID")]
    public int? ParentId { get; set; }
    [Map("cMOGOCaseID")]
    public string MOGOCaseId { get; set; } = string.Empty;
    [Map("bCustVerificationProviderReferManualCheck")]
    public bool? CustVerificationProviderReferManualCheck { get; set; }
    [Map("bAllApplicantsUnderstandEnglish")]
    public bool? AllApplicantsUnderstandEnglish { get; set; }
    [Map("fDTI")]
    public float? DTI { get; set; }
    [Map("fLTG")]
    public float? LTG { get; set; }
    [Map("iAppOriginCountry")]
    public int? AppOriginCountry { get; set; }
    [Map("bRestrictedLoan")]
    public bool? RestrictedLoan { get; set; }
    [Map("iSysAccountNo")]
    public int? SysAccountNo { get; set; }
    [Map("dLastLogin")]
    public DateTime? LastLogin { get; set; }
    [Map("fBrokerageMandate")]
    public float? BrokerageMandate { get; set; }
    [Map("bFastRefinance")]
    public bool? FastRefinance { get; set; }
    [Map("bPortalHidden")]
    public bool? PortalHidden { get; set; }
    [Map("bPortalLocked")]
    public bool? PortalLocked { get; set; }
    [Map("iTrustID")]
    public int? TrustId { get; set; }
    [Map("iMortgageArrears")]
    public int? MortgageArrears { get; set; }
    [Map("iCreditEvents")]
    public int? CreditEvents { get; set; }
    [Map("iBankruptcyStatus")]
    public int? BankruptcyStatus { get; set; }
    [Map("cQuoteNo")]
    public string QuoteNo { get; set; } = string.Empty;
    [Map("fBaseLoanAmount")]
    public float? BaseLoanAmount { get; set; }
    [Map("iCreditEventsProduct")]
    public int? CreditEventsProduct { get; set; }
    [Map("bJointNomination")]
    public bool? JointNomination { get; set; }
    [Map("iCreditEventsOverPricingPolicy")]
    public int? CreditEventsOverPricingPolicy { get; set; }
    [Map("bApprovalStatus")]
    public byte ApprovalStatus { get; set; }
    [Map("iIncomeAssessmentBasis")]
    public int? IncomeAssessmentBasis { get; set; }
    [Map("dMOGOCaseStartDate")]
    public DateTime? MOGOCaseStartDate { get; set; }
    [Map("dMOGOCaseEndDate")]
    public DateTime? MOGOCaseEndDate { get; set; }
    [Map("ilmiPolicyVersion")]
    public int? LmiPolicyVersion { get; set; }
    [Map("dcoverExpiryDate")]
    public DateTime? CoverExpiryDate { get; set; }
    public DateTime? CreatedAppDate { get; set; }
    public DateTime? AppDate { get; set; }
    public string RootApplicationId { get; set; } = string.Empty;
}
