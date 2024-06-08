using RepoDb.Attributes;
using System.ComponentModel.DataAnnotations;

namespace LoanworksBackend.Modules.Applications.Core.ApplicationSecurities;

[Map("tblAppSecurity")]
public class ApplicationSecurity
{
    [Key]
    [Map("ID")]
    public int Id { get; set; }
    [Map("iSecurityID")]
    public int SecurityId { get; set; } = default;
    [Map("iAppID")]
    [Required]
    public int AppId { get; set; } = default;
    [Map("iPropertyType")]
    public int? PropertyType { get; set; }
    [Map("fPurchasePrice")]
    public float? PurchasePrice { get; set; }
    [Map("fEstimatedValue")]
    public float? EstimatedValue { get; set; }
    [Map("bIsUsedinCapacity")]
    public byte IsUsedinCapacity { get; set; }
    [Map("cTenantName")]
    public string? TenantName { get; set; }
    [Map("iSecurityType")]
    public int? SecurityType { get; set; }
    [Map("cLot")]
    public string? Lot { get; set; }
    [Map("cFolio")]
    public string? Folio { get; set; }
    [Map("cVolume")]
    public string? Volume { get; set; }
    [Map("cFolioIndent")]
    public string? FolioIndent { get; set; }
    [Map("iMortgageStatus")]
    public int? MortgageStatus { get; set; }
    [Map("cSecurityAddress1")]
    public string? SecurityAddress1 { get; set; }
    [Map("cSecurityAddress2")]
    public string? SecurityAddress2 { get; set; }
    [Map("cSecurityAddressSuburb")]
    public string? SecurityAddressSuburb { get; set; }
    [Map("iSecurityAddressState")]
    public int? SecurityAddressState { get; set; }
    [Map("cSecurityAddressPostCode")]
    public string? SecurityAddressPostCode { get; set; }
    [Map("iInsurerCompany")]
    public int? InsurerCompany { get; set; }
    [Map("cPolicyNumber")]
    public string? PolicyNumber { get; set; }
    [Map("dExpiryDate")]
    public DateTime? ExpiryDate { get; set; }
    [Map("fSumInsured")]
    public float? SumInsured { get; set; }
    [Map("cBrokerName")]
    public string? BrokerName { get; set; }
    [Map("cBrokerContactName")]
    public string? BrokerContactName { get; set; }
    [Map("cBrokerPhone")]
    public string? BrokerPhone { get; set; }
    [Map("cBrokerEmail")]
    public string? BrokerEmail { get; set; }
    [Map("bprimary")]
    public byte Primary { get; set; }
    [Map("bconstruction")]
    public byte Construction { get; set; }
    [Map("fMinInsurancevalue")]
    public float? MinInsurancevalue { get; set; }
    [Map("cAccname")]
    public string? Accname { get; set; }
    [Map("cAccphone")]
    public string? Accphone { get; set; }
    [Map("cAccmobile")]
    public string? Accmobile { get; set; }
    [Map("fLegalFees")]
    public float? LegalFees { get; set; }
    [Map("iNumberOfBedrooms")]
    public int? NumberOfBedrooms { get; set; }
    [Map("bIsStrata")]
    public byte IsStrata { get; set; }
    [Map("iLivingAreaInSquareMetres")]
    public int? LivingAreaInSquareMetres { get; set; }
    [Map("iLandArea")]
    public int? LandArea { get; set; }
    [Map("iUnitOfMeasurement")]
    public int? UnitOfMeasurement { get; set; }
    [Map("iBuilderID")]
    public int? BuilderId { get; set; }
    [Map("fConstructionAmount")]
    public float? ConstructionAmount { get; set; }
    [Map("dConstructionStartDate")]
    public DateTime? ConstructionStartDate { get; set; }
    [Map("dConstructionEndDate")]
    public DateTime? ConstructionEndDate { get; set; }
    [Map("cSecurityNotes")]
    public string? SecurityNotes { get; set; }
    [Map("fContractPrice")]
    public float? ContractPrice { get; set; }
    [Map("fConstractLandValue")]
    public float? ConstractLandValue { get; set; }
    [Map("dYearofPurchase")]
    public DateTime? YearofPurchase { get; set; }
    [Map("iAccType")]
    public int? AccType { get; set; }
    [Map("iSecurityAddressCountry")]
    public int? SecurityAddressCountry { get; set; }
    [Map("bLegalFeeCapitalized")]
    [Required]
    public bool LegalFeeCapitalized { get; set; }
    [Map("iSecurityClass")]
    public int? SecurityClass { get; set; }
    [Map("iValuationType")]
    public int? ValuationType { get; set; }
    [Map("iZoning")]
    public int? Zoning { get; set; }
    [Map("iRuralUsage")]
    public int? RuralUsage { get; set; }
    [Map("bIsPropertyWrapContract")]
    public byte IsPropertyWrapContract { get; set; }
    [Map("bIsPropertyPurOffPlan")]
    public byte IsPropertyPurOffPlan { get; set; }
    [Map("iConstructionType")]
    public int? ConstructionType { get; set; }
    [Map("iConstructionProperyType")]
    public int? ConstructionProperyType { get; set; }
    [Map("dContractSignedOn")]
    public DateTime? ContractSignedOn { get; set; }
    [Map("bLicencedBuilder")]
    public bool? LicencedBuilder { get; set; }
    [Map("iSecurityTitleType")]
    public int? SecurityTitleType { get; set; }
    [Map("iOccupancy")]
    public int? Occupancy { get; set; }
    [Map("bOwnerBuilder")]
    public bool? OwnerBuilder { get; set; }
    [Map("bUseDetailAddress")]
    public bool? UseDetailAddress { get; set; }
    [Map("cBuildingName")]
    public string? BuildingName { get; set; }
    [Map("cLotNo")]
    public string? LotNo { get; set; }
    [Map("cUnitNo")]
    public string? UnitNo { get; set; }
    [Map("cFloorNo")]
    public string? FloorNo { get; set; }
    [Map("cStreetNo")]
    public string? StreetNo { get; set; }
    [Map("cStreetName")]
    public string? StreetName { get; set; }
    [Map("iStreetType")]
    public int? StreetType { get; set; }
    [Map("iFootPrint")]
    public int? FootPrint { get; set; }
    [Map("dTimeStamp")]
    public DateTime? TimeStamp { get; set; }
    [Map("iMortgagePriority")]
    public int? MortgagePriority { get; set; }
    [Map("fTotalPriorRankingCurrentDebt")]
    public float? TotalPriorRankingCurrentDebt { get; set; }
    [Map("iNumberOfUnits")]
    public int? NumberOfUnits { get; set; }
    [Map("iPreApproval")]
    public byte PreApproval { get; set; }
    [Map("iSecurityStatus")]
    public int? SecurityStatus { get; set; }
    [Map("bWillOwn25PercentOfComplex")]
    public bool? WillOwn25PercentOfComplex { get; set; }
    [Map("bWillOwn3UnitsInComplex")]
    public bool? WillOwn3UnitsInComplex { get; set; }
    [Map("iNumberOfBuildings")]
    public int? NumberOfBuildings { get; set; }
    [Map("iEstimatedMethodologies")]
    public int? EstimatedMethodologies { get; set; }
    [Map("iEstimatedBasis")]
    public int? EstimatedBasis { get; set; }
    [Map("cVendor")]
    public string? Vendor { get; set; }
    [Map("iIndustrialType")]
    public int? IndustrialType { get; set; }
    [Map("iInsuranceType")]
    public int? InsuranceType { get; set; }
    [Map("bLoanStatementAttached")]
    public byte LoanStatementAttached { get; set; }
    [Map("cTorrentsPlanType")]
    public string? TorrentsPlanType { get; set; }
    [Map("iUnregisteredPlan")]
    public int? UnregisteredPlan { get; set; }
    [Map("iUnregisteredLand")]
    public int? UnregisteredLand { get; set; }
    [Map("iTitleIssued")]
    public int? TitleIssued { get; set; }
    [Map("iSecurityTransaction")]
    public int? SecurityTransaction { get; set; }
    [Map("iSecurityHolding")]
    public int? SecurityHolding { get; set; }
    [Map("cSecurityConstructionStageDesc")]
    public string? SecurityConstructionStageDesc { get; set; }
    [Map("cMortgageNumber")]
    public string? MortgageNumber { get; set; }
    [Map("fMortgageStampDuty")]
    public float? MortgageStampDuty { get; set; }
    [Map("fMortgageRegistrationFee")]
    public float? MortgageRegistrationFee { get; set; }
    [Map("fTransferRegistrationFee")]
    public float? TransferRegistrationFee { get; set; }
    [Map("fDischargeRegistrationFee")]
    public float? DischargeRegistrationFee { get; set; }
    [Map("bOverrideGovernmentFeesAndCharges")]
    public int? OverrideGovernmentFeesAndCharges { get; set; }
    [Map("cTorrensBlock")]
    public string? TorrensBlock { get; set; }
    [Map("cTorrensDistrict")]
    public string? TorrensDistrict { get; set; }
    [Map("cTorrensSection")]
    public string? TorrensSection { get; set; }
    [Map("cTorrensTitleRef")]
    public string? TorrensTitleRef { get; set; }
    [Map("cTorrensLocation")]
    public string? TorrensLocation { get; set; }
    [Map("cTorrensCounty")]
    public string? TorrensCounty { get; set; }
    [Map("cTorrensParish")]
    public string? TorrensParish { get; set; }
    [Map("cTorrensExtent")]
    public string? TorrensExtent { get; set; }
    [Map("bSecurityAddressNonStandard")]
    public bool? SecurityAddressNonStandard { get; set; }
    [Map("iSecurityAddressTownCity")]
    public int? SecurityAddressTownCity { get; set; }
    [Map("bGSTLiability")]
    public byte GSTLiability { get; set; }
    [Map("cOtherParticulars")]
    public string? OtherParticulars { get; set; }
    [Map("cTitleInsurerID")]
    public string? TitleInsurerId { get; set; }
    [Map("cTitleInsurancePolicyRef")]
    public string? TitleInsurancePolicyRef { get; set; }
    [Map("dTitleInsuranceIssueDate")]
    public DateTime? TitleInsuranceIssueDate { get; set; }
    [Map("fTitleInsurancePremium")]
    public float? TitleInsurancePremium { get; set; }
    [Map("bTitleInsurancePaidbyBusiness")]
    public byte TitleInsurancePaidbyBusiness { get; set; }
    [Map("bFirstHomePurchase")]
    public byte FirstHomePurchase { get; set; }
    [Map("cTitleReferenceNo")]
    public string? TitleReferenceNo { get; set; }
    [Map("cCollateralID")]
    public string? CollateralId { get; set; }
    [Map("iSecFinalLMI")]
    public int? SecFinalLMI { get; set; }
    [Map("cSecFinalLMI")]
    public string? SecFinalLMIText { get; set; }
    [Map("iAppFinalLMI")]
    public int? AppFinalLMI { get; set; }
    [Map("cAppFinalLMI")]
    public string? AppFinalLMIText { get; set; }
    [Map("cPurposeState")]
    public string? PurposeState { get; set; }
}

