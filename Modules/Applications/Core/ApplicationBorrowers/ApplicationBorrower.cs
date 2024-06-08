using RepoDb.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoanworksBackend.Modules.Applications.Core.ApplicationBorrowers;

[Map("tblAppBorrower")]
public class ApplicationBorrower
{
    [Key]
    [Map("ID")]
    public int Id { get; set; }
    [Map("iBorrowerID")]
    [Required]
    public int BorrowerId { get; set; } = default;
    [Map("iAppID")]
    [Required]
    public int AppId { get; set; } = default;
    [Map("cCustomerID")]
    public string? CustomerId { get; set; }
    [Map("iTitle")]
    public int? Title { get; set; }
    [Map("cFirstName")]
    public string? FirstName { get; set; }
    [Map("cSurname")]
    public string? Surname { get; set; }
    [Map("dDOB")]
    public DateTime? DOB { get; set; }
    [Map("cHomePhone")]
    public string? HomePhone { get; set; }
    [Map("cMobile")]
    public string? Mobile { get; set; }
    [Map("cEmail")]
    public string? Email { get; set; }
    [Map("iMarital")]
    public int? Marital { get; set; }
    [Map("iAdults")]
    public int? Adults { get; set; }
    [Map("iChildren")]
    public int? Children { get; set; }
    [Map("cDriversNo")]
    public string? DriversNo { get; set; }
    [Map("cWorkPhone")]
    public string? WorkPhone { get; set; }
    [Map("cFax")]
    public string? Fax { get; set; }
    [Map("bPrimary")]
    public byte Primary { get; set; }
    [Map("bGuarantor")]
    public byte Guarantor { get; set; }
    [Map("bCorporate")]
    public byte Corporate { get; set; }
    [Map("cCurrentAddress1")]
    public string? CurrentAddress1 { get; set; }
    [Map("cCurrentAddress2")]
    public string? CurrentAddress2 { get; set; }
    [Map("cCurrentAddressSuburb")]
    public string? CurrentAddressSuburb { get; set; }
    [Map("iCurrentAddressState")]
    public int? CurrentAddressState { get; set; }
    [Map("cCurrentAddressPostCode")]
    public string? CurrentAddressPostCode { get; set; }
    [Map("cPreviousAddress1")]
    public string? PreviousAddress1 { get; set; }
    [Map("cPreviousAddress2")]
    public string? PreviousAddress2 { get; set; }
    [Map("cPreviousAddressSuburb")]
    public string? PreviousAddressSuburb { get; set; }
    [Map("iPreviousAddressState")]
    public int? PreviousAddressState { get; set; }
    [Map("cPreviousAddressPostCode")]
    public string? PreviousAddressPostCode { get; set; }
    [Map("cMailingAddress1")]
    public string? MailingAddress1 { get; set; }
    [Map("cMailingAddress2")]
    public string? MailingAddress2 { get; set; }
    [Map("cMailingAddressSuburb")]
    public string? MailingAddressSuburb { get; set; }
    [Map("iMailingAddressState")]
    public int? MailingAddressState { get; set; }
    [Map("cMailingAddressPostCode")]
    public string? MailingAddressPostCode { get; set; }
    [Map("cResidentialAddress1")]
    public string? ResidentialAddress1 { get; set; }
    [Map("cResidentialAddress2")]
    public string? ResidentialAddress2 { get; set; }
    [Map("cResidentialAddressSuburb")]
    public string? ResidentialAddressSuburb { get; set; }
    [Map("iResidentialAddressState")]
    public int? ResidentialAddressState { get; set; }
    [Map("cResidentialAddressPostCode")]
    public string? ResidentialAddressPostCode { get; set; }
    [Map("iYearsCurrentAddress")]
    public int? YearsCurrentAddress { get; set; }
    [Map("iMonthsCurrentAddress")]
    public int? MonthsCurrentAddress { get; set; }
    [Map("iYearsPreviousAddress")]
    public int? YearsPreviousAddress { get; set; }
    [Map("iMonthsPreviousAddress")]
    public int? MonthsPreviousAddress { get; set; }
    [Map("bIsMailingPostSettlement")]
    public byte IsMailingPostSettlement { get; set; }
    [Map("bIsMailingCurrent")]
    public byte IsMailingCurrent { get; set; }
    [Map("cResidentialLandLord")]
    public string? ResidentialLandLord { get; set; }
    [Map("fResidentialPayment")]
    public float? ResidentialPayment { get; set; }
    [Map("cResidentialContact")]
    public string? ResidentialContact { get; set; }
    [Map("cResidentialPhone")]
    public string? ResidentialPhone { get; set; }
    [Map("cOccupation")]
    public string? Occupation { get; set; }
    [Map("cCurrentEmpName")]
    public string? CurrentEmpName { get; set; }
    [Map("cCurrentEmpContact")]
    public string? CurrentEmpContact { get; set; }
    [Map("cCurrentEmpPhone")]
    public string? CurrentEmpPhone { get; set; }
    [Map("fCurrentEmpIncome")]
    public float? CurrentEmpIncome { get; set; }
    [Map("cCurrentEmpAddress1")]
    public string? CurrentEmpAddress1 { get; set; }
    [Map("cCurrentEmpAddress2")]
    public string? CurrentEmpAddress2 { get; set; }
    [Map("cCurrentEmpAddressSuburb")]
    public string? CurrentEmpAddressSuburb { get; set; }
    [Map("iCurrentEmpAddressState")]
    public int? CurrentEmpAddressState { get; set; }
    [Map("cCurrentEmpAddressPostCode")]
    public string? CurrentEmpAddressPostCode { get; set; }
    [Map("iCurrentEmpYears")]
    public int? CurrentEmpYears { get; set; }
    [Map("iCurrentEmpMonths")]
    public int? CurrentEmpMonths { get; set; }
    [Map("cPreviousEmpName")]
    public string? PreviousEmpName { get; set; }
    [Map("cPreviousEmpAddress1")]
    public string? PreviousEmpAddress1 { get; set; }
    [Map("cPreviousEmpAddress2")]
    public string? PreviousEmpAddress2 { get; set; }
    [Map("cPreviousEmpAddressSuburb")]
    public string? PreviousEmpAddressSuburb { get; set; }
    [Map("iPreviousEmpAddressState")]
    public int? PreviousEmpAddressState { get; set; }
    [Map("cPreviousEmpAddressPostCode")]
    public string? PreviousEmpAddressPostCode { get; set; }
    [Map("iPreviousEmpYears")]
    public int? PreviousEmpYears { get; set; }
    [Map("cSolicitorPracticeName")]
    public string? SolicitorPracticeName { get; set; }
    [Map("cSolicitorContactName")]
    public string? SolicitorContactName { get; set; }
    [Map("cSolicitorPhone")]
    public string? SolicitorPhone { get; set; }
    [Map("cSolicitorFax")]
    public string? SolicitorFax { get; set; }
    [Map("cSolicitorEmail")]
    public string? SolicitorEmail { get; set; }
    [Map("cSolicitorMobile")]
    public string? SolicitorMobile { get; set; }
    [Map("cSolicitorDX")]
    public string? SolicitorDX { get; set; }
    [Map("cAccountantPracticeName")]
    public string? AccountantPracticeName { get; set; }
    [Map("cAccountantContactName")]
    public string? AccountantContactName { get; set; }
    [Map("cAccountantAddress1")]
    public string? AccountantAddress1 { get; set; }
    [Map("cAccountantAddress2")]
    public string? AccountantAddress2 { get; set; }
    [Map("cAccountantAddressSuburb")]
    public string? AccountantAddressSuburb { get; set; }
    [Map("iAccountantAddressState")]
    public int? AccountantAddressState { get; set; }
    [Map("cAccountantAddressPostCode")]
    public string? AccountantAddressPostCode { get; set; }
    [Map("cAccountantPhone")]
    public string? AccountantPhone { get; set; }
    [Map("cAccountantFax")]
    public string? AccountantFax { get; set; }
    [Map("cAccountantEmail")]
    public string? AccountantEmail { get; set; }
    [Map("cAccountantMobile")]
    public string? AccountantMobile { get; set; }
    [Map("cAccountantDX")]
    public string? AccountantDX { get; set; }
    [Map("cSolicitoraddress1")]
    public string? Solicitoraddress1 { get; set; }
    [Map("cSolicitoraddress2")]
    public string? Solicitoraddress2 { get; set; }
    [Map("cSolicitorsuburb")]
    public string? Solicitorsuburb { get; set; }
    [Map("iSolicitorstate")]
    public int? Solicitorstate { get; set; }
    [Map("cSolicitorpcode")]
    public string? Solicitorpcode { get; set; }
    [Map("bActingForSelf")]
    public byte ActingForSelf { get; set; }
    [Map("cSolicitorABN")]
    public string? SolicitorABN { get; set; }
    [Map("iSex")]
    public int? Sex { get; set; }
    [Map("iCurrentEmploymentTypeID")]
    public int? CurrentEmploymentTypeId { get; set; }
    [Map("iPrevEmploymentTypeID")]
    public int? PrevEmploymentTypeId { get; set; }
    [Map("iDriverState")]
    public int? DriverState { get; set; }
    [Map("fPreviousEmpIncome")]
    public float? PreviousEmpIncome { get; set; }
    [Map("dStatementOfPositionDate")]
    public DateTime? StatementOfPositionDate { get; set; }
    [Map("iStatementOfPositionSigned")]
    public int? StatementOfPositionSigned { get; set; }
    [Map("cWebUserName")]
    public string? WebUserName { get; set; }
    [Map("cWebUserPassword")]
    public string? WebUserPassword { get; set; }
    [Map("iWebAccessStatus")]
    public int? WebAccessStatus { get; set; }
    [Map("cMiddleName")]
    public string? MiddleName { get; set; }
    [Map("fCurrentEmpNetIncome")]
    public float? CurrentEmpNetIncome { get; set; }
    [Map("fPreviousEmpNetIncome")]
    public float? PreviousEmpNetIncome { get; set; }
    [Map("dCurEmpStartDate")]
    public DateTime? CurEmpStartDate { get; set; }
    [Map("dCurEmpEndDate")]
    public DateTime? CurEmpEndDate { get; set; }
    [Map("dPrevEmpStartDate")]
    public DateTime? PrevEmpStartDate { get; set; }
    [Map("dPrevEmpEndDate")]
    public DateTime? PrevEmpEndDate { get; set; }
    [Map("cPrevOccupation")]
    public string? PrevOccupation { get; set; }
    [Map("cNotes")]
    public string? Notes { get; set; }
    [Map("iMarketingStatus")]
    public int? MarketingStatus { get; set; }
    [Map("iCurEmpIndustryID")]
    public int? CurEmpIndustryId { get; set; }
    [Map("iPrevEmpIndustryID")]
    public int? PrevEmpIndustryId { get; set; }
    [Map("iCustID")]
    public int? CustId { get; set; }
    [Map("dCurrentAddressDateFrom")]
    public DateTime? CurrentAddressDateFrom { get; set; }
    [Map("dCurrentAddressDateTo")]
    public DateTime? CurrentAddressDateTo { get; set; }
    [Map("dPreviousAddressDateFrom")]
    public DateTime? PreviousAddressDateFrom { get; set; }
    [Map("dPreviousAddressDateTo")]
    public DateTime? PreviousAddressDateTo { get; set; }
    [Map("dMailingAddressDateFrom")]
    public DateTime? MailingAddressDateFrom { get; set; }
    [Map("dMailingAddressDateTo")]
    public DateTime? MailingAddressDateTo { get; set; }
    [Map("bPermanentResident")]
    [Required]
    public bool PermanentResident { get; set; }
    [Map("bFHOG")]
    public byte FHOG { get; set; }
    [Map("iAgeofDept1")]
    public int? AgeofDept1 { get; set; }
    [Map("iAgeofDept2")]
    public int? AgeofDept2 { get; set; }
    [Map("iAgeofDept3")]
    public int? AgeofDept3 { get; set; }
    [Map("iAgeofDept4")]
    public int? AgeofDept4 { get; set; }
    [Map("iAgeofDept5")]
    public int? AgeofDept5 { get; set; }
    [Map("iAgeofDept6")]
    public int? AgeofDept6 { get; set; }
    [Map("bSameasPostSettlementResidential")]
    public byte SameasPostSettlementResidential { get; set; }
    [Map("cCurrentABN")]
    public string? CurrentABN { get; set; }
    [Map("iCurrentRegState")]
    public int? CurrentRegState { get; set; }
    [Map("cPreABN")]
    public string? PreABN { get; set; }
    [Map("iPreRegState")]
    public int? PreRegState { get; set; }
    [Map("cPreEmpPhone")]
    public string? PreEmpPhone { get; set; }
    [Map("iPreMonth")]
    public int? PreMonth { get; set; }
    [Map("bNominated")]
    public bool? Nominated { get; set; }
    [Map("iPoliticallyExposed")]
    public int? PoliticallyExposed { get; set; }
    [Map("iCurrentAddressCountry")]
    public int? CurrentAddressCountry { get; set; }
    [Map("iPreviousAddressCountry")]
    public int? PreviousAddressCountry { get; set; }
    [Map("iMailingAddressCountry")]
    public int? MailingAddressCountry { get; set; }
    [Map("iCurrentEmpAddressCountry")]
    public int? CurrentEmpAddressCountry { get; set; }
    [Map("iPreviousEmpAddressCountry")]
    public int? PreviousEmpAddressCountry { get; set; }
    [Map("iAccountantAddressCountry")]
    public int? AccountantAddressCountry { get; set; }
    [Map("iSolicitorCountry")]
    public int? SolicitorCountry { get; set; }
    [Map("iLandLordCountry")]
    public int? LandLordCountry { get; set; }
    [Map("bPoliticallyExposed")]
    public int? IsPoliticallyExposed { get; set; }
    [Map("cTrustName")]
    public string? TrustName { get; set; }
    [Map("dTrustDate")]
    public DateTime? TrustDate { get; set; }
    [Map("iOwnerStatus")]
    public int? OwnerStatus { get; set; }
    [Map("bOnProbation")]
    public bool? OnProbation { get; set; }
    [Map("iPreviousOwnerStatus")]
    public int? PreviousOwnerStatus { get; set; }
    [Map("cCurrentEmpABN")]
    public string? CurrentEmpABN { get; set; }
    [Map("cCurrentEmpACN")]
    public string? CurrentEmpACN { get; set; }
    [Map("iCurrentSelfEmpType")]
    public int? CurrentSelfEmpType { get; set; }
    [Map("iTFNExemption")]
    public int? TFNExemption { get; set; }
    [Map("cApplicantTaxFileNumber")]
    public string? ApplicantTaxFileNumber { get; set; }
    [Map("bApplicantbankrupt")]
    public bool? Applicantbankrupt { get; set; }
    [Map("bApplicantcourtjudgements")]
    public bool? Applicantcourtjudgements { get; set; }
    [Map("cMotherMaidenName")]
    public string? MotherMaidenName { get; set; }
    [Map("dDriverLicenseExpiryDate")]
    public DateTime? DriverLicenseExpiryDate { get; set; }
    [Map("iRelationshipToBorrower")]
    public int? RelationshipToBorrower { get; set; }
    [Map("iNextofKinTitle")]
    public int? NextofKinTitle { get; set; }
    [Map("cNextofKinFirstName")]
    public string? NextofKinFirstName { get; set; }
    [Map("cNextofKinMiddleName")]
    public string? NextofKinMiddleName { get; set; }
    [Map("cNextofKinSurname")]
    public string? NextofKinSurname { get; set; }
    [Map("cNextofKinAddress1")]
    public string? NextofKinAddress1 { get; set; }
    [Map("cNextofKinAddress2")]
    public string? NextofKinAddress2 { get; set; }
    [Map("cNextofKinSuburb")]
    public string? NextofKinSuburb { get; set; }
    [Map("cNextofKinPostCode")]
    public string? NextofKinPostCode { get; set; }
    [Map("iNextofKinState")]
    public int? NextofKinState { get; set; }
    [Map("iNextofKinCountry")]
    public int? NextofKinCountry { get; set; }
    [Map("cNextofKinPhoneNumber")]
    public string? NextofKinPhoneNumber { get; set; }
    [Map("cPreferredName")]
    public string? PreferredName { get; set; }
    [Map("bHasPreviousName")]
    public bool? HasPreviousName { get; set; }
    [Map("cPreviousFirstName")]
    public string? PreviousFirstName { get; set; }
    [Map("cPreviousMiddleName")]
    public string? PreviousMiddleName { get; set; }
    [Map("cPreviousSurname")]
    public string? PreviousSurname { get; set; }
    [Map("cNameChangeReason")]
    public string? NameChangeReason { get; set; }
    [Map("bAllowCreditCheck")]
    public bool? AllowCreditCheck { get; set; }
    [Map("dCreditAuthorityDateSigned")]
    public DateTime? CreditAuthorityDateSigned { get; set; }
    [Map("bAllowThirdPartyDisclosure")]
    public bool? AllowThirdPartyDisclosure { get; set; }
    [Map("bPrivacyActConsentSigned")]
    public bool? PrivacyActConsentSigned { get; set; }
    [Map("dPrivacyActConsentDateSigned")]
    public DateTime? PrivacyActConsentDateSigned { get; set; }
    [Map("bUnderstandApplication")]
    public bool? UnderstandApplication { get; set; }
    [Map("iTaxStatus")]
    public int? TaxStatus { get; set; }
    [Map("iTaxCountry")]
    public int? TaxCountry { get; set; }
    [Map("iTINNotProvidedReason")]
    public int? TINNotProvidedReason { get; set; }
    [Map("cTINNotProvidedReasonDetails")]
    public string? TINNotProvidedReasonDetails { get; set; }
    [Map("iCitizenshipForTaxPurposesCountry")]
    public int? CitizenshipForTaxPurposesCountry { get; set; }
    [Map("iCurrentOccupationCode")]
    public int? CurrentOccupationCode { get; set; }
    [Map("iEmployerType")]
    public int? EmployerType { get; set; }
    [Map("cMainBusinessActivity")]
    public string? MainBusinessActivity { get; set; }
    [Map("dProbationStartDate")]
    public DateTime? ProbationStartDate { get; set; }
    [Map("dProbationEndDate")]
    public DateTime? ProbationEndDate { get; set; }
    [Map("iNumberofEmployees")]
    public int? NumberofEmployees { get; set; }
    [Map("iNumberofLocations")]
    public int? NumberofLocations { get; set; }
    [Map("bIsAFranchise")]
    public bool? IsAFranchise { get; set; }
    [Map("iOwnPremises")]
    public int? OwnPremises { get; set; }
    [Map("iTaxOfficeAssessment")]
    public int? TaxOfficeAssessment { get; set; }
    [Map("iResidencyStatus")]
    public int? ResidencyStatus { get; set; }
    [Map("dPermanentResidencyDate")]
    public DateTime? PermanentResidencyDate { get; set; }
    [Map("iCitizenshipCountry")]
    public int? CitizenshipCountry { get; set; }
    [Map("iMailingAddressType")]
    public int? MailingAddressType { get; set; }
    [Map("iMailingAddressPOBoxType")]
    public int? MailingAddressPOBoxType { get; set; }
    [Map("cPriorNonStandardAdd1")]
    public string? PriorNonStandardAdd1 { get; set; }
    [Map("cPriorNonStandardAdd2")]
    public string? PriorNonStandardAdd2 { get; set; }
    [Map("cPriorAddressSuburb")]
    public string? PriorAddressSuburb { get; set; }
    [Map("iPriorAddressState")]
    public int? PriorAddressState { get; set; }
    [Map("cPriorAddressPostCode")]
    public string? PriorAddressPostCode { get; set; }
    [Map("iPriorAddressCountry")]
    public int? PriorAddressCountry { get; set; }
    [Map("dPriorAddressDateFrom")]
    public DateTime? PriorAddressDateFrom { get; set; }
    [Map("dPriorAddressDateTo")]
    public DateTime? PriorAddressDateTo { get; set; }
    [Map("iYearsPriorAddress")]
    public int? YearsPriorAddress { get; set; }
    [Map("iMonthsPriorAddress")]
    public int? MonthsPriorAddress { get; set; }
    [Map("iPriorOwnerStatus")]
    public int? PriorOwnerStatus { get; set; }
    [Map("iCurrentAddressFormat")]
    public int? CurrentAddressFormat { get; set; }
    [Map("cCurrentAddressBuildingName")]
    public string? CurrentAddressBuildingName { get; set; }
    [Map("cCurrentAddressFloorNo")]
    public string? CurrentAddressFloorNo { get; set; }
    [Map("cCurrentAddressUnitNo")]
    public string? CurrentAddressUnitNo { get; set; }
    [Map("cCurrentAddressStreetNo")]
    public string? CurrentAddressStreetNo { get; set; }
    [Map("cCurrentAddressStreetName")]
    public string? CurrentAddressStreetName { get; set; }
    [Map("iCurrentAddressStreetType")]
    public int? CurrentAddressStreetType { get; set; }
    [Map("iPreviousAddressFormat")]
    public int? PreviousAddressFormat { get; set; }
    [Map("cPreviousAddressBuildingName")]
    public string? PreviousAddressBuildingName { get; set; }
    [Map("cPreviousAddressFloorNo")]
    public string? PreviousAddressFloorNo { get; set; }    
    [Map("cPreviousAddressUnitNo")]
    public string? PreviousAddressUnitNo { get; set; }
    [Map("cPreviousAddressStreetNo")]
    public string? PreviousAddressStreetNo { get; set; }
    [Map("cPreviousAddressStreetName")]
    public string? PreviousAddressStreetName { get; set; }
    [Map("iPreviousAddressStreetType")]
    public int? PreviousAddressStreetType { get; set; }
    [Map("iPriorAddressFormat")]
    public int? PriorAddressFormat { get; set; }
    [Map("cPriorAddressBuildingName")]
    public string? PriorAddressBuildingName { get; set; }
    [Map("cPriorAddressFloorNo")]
    public string? PriorAddressFloorNo { get; set; }
    [Map("cPriorAddressUnitNo")]
    public string? PriorAddressUnitNo { get; set; }
    [Map("cPriorAddressStreetNo")]
    public string? PriorAddressStreetNo { get; set; }
    [Map("cPriorAddressStreetName")]
    public string? PriorAddressStreetName { get; set; }
    [Map("iPriorAddressStreetType")]
    public int? PriorAddressStreetType { get; set; }
    [Map("iMailingAddressFormat")]
    public int? MailingAddressFormat { get; set; }
    [Map("cMailingAddressBuildingName")]
    public string? MailingAddressBuildingName { get; set; }
    [Map("cMailingAddressFloorNo")]
    public string? MailingAddressFloorNo { get; set; }
    [Map("cMailingAddressUnitNo")]
    public string? MailingAddressUnitNo { get; set; }
    [Map("cMailingAddressStreetNo")]
    public string? MailingAddressStreetNo { get; set; }
    [Map("cMailingAddressStreetName")]
    public string? MailingAddressStreetName { get; set; }
    [Map("iMailingAddressStreetType")]
    public int? MailingAddressStreetType { get; set; }
    [Map("bReceiveKeyStatusUpdateviaEmailSMS")]
    public bool? ReceiveKeyStatusUpdateviaEmailSMS { get; set; }
    [Map("iIDPEPFlag")]
    public int? IDPEPFlag { get; set; }
    [Map("iIDSanctionedFlag")]
    public int? IDSanctionedFlag { get; set; }
    [Map("bCreditAuthoritySigned")]
    public bool? CreditAuthoritySigned { get; set; }
    [Map("bLimitedGuarantee")]
    public byte LimitedGuarantee { get; set; }
    [Display(Name = "GurantorLiabilityLimitedTo")]
    [Column(TypeName = "decimal(19, 2)")]
    [Map("fGurantorLiabilityLimitedTo")]
    public decimal GurantorLiabilityLimitedTo { get; set; }
    [Map("iFHOGStatus")]
    public int? FHOGStatus { get; set; }
    [Map("cFHOGReferenceNumber")]
    public string? FHOGReferenceNumber { get; set; }
    [Map("bCurrentAddressNonStandard")]
    public bool? CurrentAddressNonStandard { get; set; }
    [Map("bMailingAddressNonStandard")]
    public bool? MailingAddressNonStandard { get; set; }
    [Map("bPreviousAddressNonStandard")]
    public bool? PreviousAddressNonStandard { get; set; }
    [Map("bPriorAddressNonStandard")]
    public bool? PriorAddressNonStandard { get; set; }
    [Map("iCurrentAddressTownCity")]
    public int? CurrentAddressTownCity { get; set; }
    [Map("iPreviousAddressTownCity")]
    public int? PreviousAddressTownCity { get; set; }
    [Map("iPriorAddressTownCity")]
    public int? PriorAddressTownCity { get; set; }
    [Map("iMailingAddressTownCity")]
    public int? MailingAddressTownCity { get; set; }
    [Map("iCurrentEmpAddressTownCity")]
    public int? CurrentEmpAddressTownCity { get; set; }
    [Map("iPreviousEmpAddressTownCity")]
    public int? PreviousEmpAddressTownCity { get; set; }
    [Map("iSolicitorAddressTownCity")]
    public int? SolicitorAddressTownCity { get; set; }
    [Map("iAccountantAddressTownCity")]
    public int? AccountantAddressTownCity { get; set; }
    [Map("iResidentialAddressTownCity")]
    public int? ResidentialAddressTownCity { get; set; }
    [Map("iResidencyCountry")]
    public int? ResidencyCountry { get; set; }
    [Map("iCitizenshipStatus")]
    public int? CitizenshipStatus { get; set; }
    [Map("bFraudMatch")]
    public bool? FraudMatch { get; set; }
    [Map("bDVSConsent")]
    public bool? DVSConsent { get; set; }
    [Map("iCurrentAddressType")]
    public int? CurrentAddressType { get; set; }
    [Map("iCurrentAddressPOBoxType")]
    public int? CurrentAddressPOBoxType { get; set; }
    [Map("bIncludeInServiceability")]
    public bool? IncludeInServiceability { get; set; }
    [Map("iPrevOccupationCode")]
    public int? PrevOccupationCode { get; set; }
    [Map("dCurrentSelfEmpABNRegDate")]
    public DateTime? CurrentSelfEmpABNRegDate { get; set; }
    [Map("dCurrentSelfEmpGSTRegDate")]
    public DateTime? CurrentSelfEmpGSTRegDate { get; set; }
    [Map("iSoftTouchCreditInquiry")]
    public int? SoftTouchCreditInquiry { get; set; }
    [Map("iFinancialVerificationStatus")]
    public string? FinancialVerificationStatus { get; set; }
    [Map("iPrevSelfEmpType")]
    public int? PrevSelfEmpType { get; set; }
    [Map("cThirdPartyField1")]
    public string? ThirdPartyField1 { get; set; }
    [Map("cThirdPartyField2")]
    public string? ThirdPartyField2 { get; set; }
    [Map("bInternetBanking")]
    public bool? InternetBanking { get; set; }
}

