using RepoDb.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoanworksBackend.Modules.Applications.Core.ApplicationProduct;

[Map("tblAppProduct")]
public class AppProduct
{
    [Key]
    [Map("ID")]
    public int Id { get; set; }
    [Map("iAppProductID")]
    [Required]
    public int AppProductId { get; set; } = default;
    [Map("iAppID")]
    [Required]
    public int AppId { get; set; } = default;
    [Map("iProdID")]
    public int? ProdId { get; set; }
    [Map("cAPProductName")]
    public string? APProductName { get; set; }
    [Map("fAPBorrowerRate")]
    public float? APBorrowerrate { get; set; }
    [Map("fAPDeliveryRate")]
    public float? APDeliveryRate { get; set; }
    [Map("fAPAmount")]
    public float? ApAmount { get; set; }
    [Map("fAPRepayments")]
    public float? APRepayments { get; set; }
    [Map("cAPLoanType")]
    public string? APLoanType { get; set; }
    [Map("cAPProductType")]
    public string? APProductType { get; set; }
    [Map("dAPMaturity")]
    public DateTime? APMaturity { get; set; }
    [Map("iAPTermYear")]
    public int? APTermYear { get; set; }
    [Map("iAPTermMonth")]
    public int? APTermMonth { get; set; }
    [Map("cAPFrequency")]
    public string? APFrequency { get; set; }
    [Map("cAPFinancier")]
    public string? APFinancier { get; set; }
    [Map("cFinprodcode")]
    public string? Finprodcode { get; set; }
    [Map("cFinprodname")]
    public string? Finprodname { get; set; }
    [Map("cAPProductLoanType")]
    public string? APProductLoanType { get; set; }
    [Map("cPortionCode")]
    public string? PortionCode { get; set; }
    [Map("fSacrificeRate")]
    public float? SacrificeRate { get; set; }
    [Map("fOriginatorMargin")]
    public float? OriginatorMargin { get; set; }
    [Map("fOtherMargin")]
    public float? OtherMargin { get; set; }
    [Map("fIncentiveRate")]
    public float? IncentiveRate { get; set; }
    [Map("bLineOfCredit")]
    public byte LineOfCredit { get; set; }
    [Map("iSacrificeMonths")]
    public int? SacrificeMonths { get; set; }
    [Map("iLoanPurposeType")]
    public int? LoanPurposeType { get; set; }
    [Map("fDiscountRate")]
    public float? DiscountRate { get; set; }
    [Map("iInterestOnlyMonth")]
    public int? InterestOnlyMonth { get; set; }
    [Map("iFixedInterestMonth")]
    public int? FixedInterestMonth { get; set; }
    [Map("fBorrowerInitialRate")]
    public float? BorrowerInitialRate { get; set; }
    [Map("fIntroductoryRate")]
    public float? IntroductoryRate { get; set; }
    [Map("fIntroductoryRepayment")]
    public float? IntroductoryRepayment { get; set; }
    [Map("fTrailPercentage")]
    public float? TrailPercentage { get; set; }
    [Map("fUpfrontPercentage")]
    public float? UpfrontPercentage { get; set; }
    [Map("fUpfrontDollars")]
    public float? UpfrontDollars { get; set; }
    [Map("bOver_fSacrificeRate")]
    public int? Over_fSacrificeRate { get; set; }
    [Map("bOver_fOriginatorMargin")]
    public int? Over_fOriginatorMargin { get; set; }
    [Map("bOver_fIncentiveRate")]
    public int? Over_fIncentiveRate { get; set; }
    [Map("bOver_fTrailPercentage")]
    public int? Over_fTrailPercentage { get; set; }
    [Map(" bOver_fUpfrontPercentage")]
    public int? Over_fUpfrontPercentage { get; set; }
    [Map("bOver_fUpfrontDollars")]
    public int? Over_fUpfrontDollars { get; set; }
    [Map("iUserID")]
    public int? UserID { get; set; }
    [Map("dTimeStamp")]
    public DateTime? TimeStamp { get; set; }
    [Map("fTheoreticalBalance")]
    public float? TheoreticalBalance { get; set; }
    [Map("bRegulated")]
    public byte Regulated { get; set; }
    [Map("fDeliveryRate")]
    public float? DeliveryRate { get; set; }
    [Map("bOver_fDeliveryRate")]
    public int? Over_fDeliveryRate { get; set; }
    [Map("fConstructionLoading")]
    public float? ConstructionLoading { get; set; }
    [Map("bOver_fConstructionLoading")]
    public int? Over_fConstructionLoading { get; set; }
    [Map("fVacantLandLoading")]
    public float? VacantLandLoading { get; set; }
    [Map("bOver_fVacantLandLoading")]
    public int? Over_fVacantLandLoading { get; set; }
    [Map("fOtherLoading")]
    public float? OtherLoading { get; set; }
    [Map("bOver_fOtherLoading")]
    public int? Over_fOtherLoading { get; set; }
    [Map("fFunderUpfrontExp")]
    public float? FunderUpfrontExp { get; set; }
    [Map("fFunderUpfrontRcv")]
    public float? fFunderUpfrontRcv { get; set; }
    [Map("dFunderUpfrontRcv")]
    public DateTime? dFunderUpfrontRcv { get; set; }
    [Map("fIniDrawdownAmt")]
    public float? IniDrawdownAmt { get; set; }
    [Map("fInitialAmount")]
    public float? InitialAmount { get; set; }
    [Map("bIncludeConsolidatedLiabilities")]
    public bool? IncludeConsolidatedLiabilities { get; set; }
    [Map("bIncludeCapitalisedFees")]
    public bool? IncludeCapitalisedFees { get; set; }
    [Map("bIncludeCapitalisedStampDuties")]
    public bool? IncludeCapitalisedStampDuties { get; set; }
    [Map("fBaseFixedRate")]
    public float? BaseFixedRate { get; set; }
    [Map("iFixedRateTerm")]
    public int? FixedRateTerm { get; set; }
    [Map("iInterestOnlyTerm")]
    public int? InterestOnlyTerm { get; set; }
    [Map("fInterestOnlyLoading")]
    public float? InterestOnlyLoading { get; set; }
    [Map("iDefaultLoanType")]
    public int? DefaultLoanType { get; set; }
    [Map("iInitialOption")]
    public int? InitialOption { get; set; }
    [Map("bOver_fBaseFixedRate")]
    public int? Over_fBaseFixedRate { get; set; }
    [Map("bOver_fInterestOnlyLoading")]
    public int? Over_fInterestOnlyLoading { get; set; }
    [Map("bOver_InitialBorrowerRate")]
    public bool? Over_InitialBorrowerRate { get; set; }
    [Map("bLinkedDebitCard")]
    public int? LinkedDebitCard { get; set; }
    [Map("bOver_Rates")]
    public int? Over_Rates { get; set; }
    [Map("fOverridenOriginatorMargin")]
    public float? OverridenOriginatorMargin { get; set; }
    [Map("cLinkedSavingAccount")]
    public string? LinkedSavingAccount { get; set; }
    [Map("bMainProduct")]
    public bool? MainProduct { get; set; }
    [Map("cInterestOnlyReason")]
    public string? InterestOnlyReason { get; set; }
    [Map("iDefaultRollOverLoanType")]
    public string? DefaultRollOverLoanType { get; set; }
    [Map("fRollOverRate")]
    public float? RollOverRate { get; set; }
    [Map("fRollOverDeliveryRate")]
    public float? RollOverDeliveryRate { get; set; }
    [Map("fRollOverSacrificeRate")]
    public float? RollOverSacrificeRate { get; set; }
    [Map("fRollOverIncentiveRate")]
    public float? RollOverIncentiveRate { get; set; }
    [Map("fRollOverOriginatorRate")]
    public float? RollOverOriginatorRate { get; set; }
    [Map("fRollOverOtherLoadingRate")]
    public float? RollOverOtherLoadingRate { get; set; }
    [Map("iRollOverSacrificeMonths")]
    public int? RollOverSacrificeMonths { get; set; }
    [Map("fRollOverConstructionLoading")]
    public float? RollOverConstructionLoading { get; set; }
    [Map("fRollOverVacantLandLoading")]
    public float? RollOverVacantLandLoading { get; set; }
    [Map("bROver_Rates")]
    public int? ROver_Rates { get; set; }
    [Map("iFixedRateLock")]
    public int? FixedRateLock { get; set; }
    [Map("dRateLockExpiryDate")]
    public DateTime? RateLockExpiryDate { get; set; }
    [Map("fFinalRepayment")]
    public float? FinalRepayment { get; set; }
    [Map("iDynamicRepayments")]
    public int? iDynamicRepayments { get; set; }
    [Map("cPortionLetterCode")]
    public string? PortionLetterCode { get; set; }
    [Map("bDynamicRepayments")]
    public bool? bDynamicRepayments { get; set; }
    [Map("iProductLoanPurpose")]
    public int? ProductLoanPurpose { get; set; }
    public string? cBaseRateCode { get; set; }
    public string? cInterestCode { get; set; }
    public string? fBaseRateCode { get; set; }
    public string? fInterestCode { get; set; }
    [Map("cBaseRateCodeVer")]
    public string? BaseRateCodeVer { get; set; }
    [Map("cInterestCodeVer")]
    public string? InterestCodeVer { get; set; }
    public string? cBBTableCode { get; set; }
    public float? fBBTableCode { get; set; }
    [Map("cBBTableCodeVer")]
    public string? BBTableCodeVer { get; set; }
    [Map("fComparisonRate")]
    public float? ComparisonRate { get; set; }
    [Map("applicationClassId")]
    public int? ApplicationClassId { get; set; }
    [Map("loyaltyProgramTypeId")]
    public int? LoyaltyProgramTypeId { get; set; }
    [Display(Name = "BalloonPercent")]
    [Column(TypeName = "decimal(19, 2)")]
    [Map("balloonPercent")]
    public decimal BalloonPercent { get; set; }
    [Display(Name = "BalloonValue")]
    [Column(TypeName = "decimal(19, 2)")]
    [Map("balloonValue")]
    public decimal BalloonValue { get; set; }
}


