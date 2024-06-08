using RepoDb.Attributes;
using System.ComponentModel.DataAnnotations;

namespace LoanworksBackend.Modules.Management.Core.Products;

public class Product
{
    [Key]
    [Map("iProdID")]
    public int productId { get; set; }
    [Map("cProdCode")]
    public string? productCode { get; set; }
    [Map("cProdName")]
    public string? productName { get; set; }
    [Map("iProdType")]
    public int? productType { get; set; }
    [Map("fRate")]
    public decimal? rate { get; set; }
    [Map("fRate_Del")]
    public decimal? deliveryRate { get; set; }
    [Map("iTermYear")]
    public int? termYear { get; set; }
    [Map("iTermMonth")]
    public int? termMonth { get; set; }
    [Map("iFinancierID")]
    public int? financierID { get; set; }
    [Map("cFinancier")]
    public string? financier { get; set; }
    [Map("cLender")]
    public string? lender { get; set; }

    [Map("cRepayType")]
    public string? repayType { get; set; }
    



    
    [Map("iSplit")]
    public int? split { get; set; }
    [Map("dMaturity")]
    public DateTime? dateMaturity { get; set; }
    [Map("dUdpdated")]
    public DateTime? dateUpdated { get; set; }
    [Map("iRepayType")]
    public int? repaymentTypeId { get; set; }
    [Map("fMinLoan")]
    public decimal? minLoan { get; set; }
    [Map("fMaxLoan")]
    public decimal? maxLoan { get; set; }
    [Map("cdescnote")]
    public string? descriptionNote { get; set; }
     [Map("crepaynote")]
    public string? repaymentNote { get; set; }
    [Map("cFinprodcode")]
    public string? financierProductCode { get; set; }
    [Map("cFinprodname")]
    public string? financierProductName { get; set; }
    [Map("fSubsidyMargin")]
    public decimal? subsidyMargin { get; set; }
    [Map("fOrganizationMargin")]
    public decimal? organizationMargin { get; set; }
    [Map("fOtherMargin")]
    public decimal? otherMargin { get; set; }
    [Map("iSacrificeMonths")]
    public int? sacrificeMonths { get; set; }
    [Map("fIncentiveRate")]
    public decimal? incentiveRate { get; set; }
    [Map("bLineofCredit")]
    public bool? lineofCredit { get; set; }
    [Map("fTrailPercentage")]
    public decimal? trailPercentage { get; set; }
    [Map("fUpfrontPercentage")]
    public decimal? upfrontPercentage { get; set; }
    [Map("fUpfrontDollars")]
    public decimal? upfrontDollars { get; set; }
    [Map("iProductStatusLookupID")]
    public int? productStatusLookupId { get; set; }
    [Map("iProductStatusID")]
    public int? productStatusId { get; set; }
    [Map("iFootPrint")]
    public int? footPrint { get; set; }
    [Map("iIncludeInComparison")]
    public int? includeInComparison { get; set; }
    [Map("iWebbrokerDisplay")]
    public int? webBrokerDisplay { get; set; }
    [Map("fConstructionLoading")]
    public decimal? constructionLoading { get; set; }
    [Map("fVacantLandLoading")]
    public decimal? vacantLandLoading { get; set; }
    [Map("fOtherLoading")]
    public decimal? otherLoading { get; set; }
    [Map("fBaseFixedRate")]
    public decimal? baseFixedRate { get; set; }
    [Map("iFixedRateTerm")]
    public int? fixedRateTerm { get; set; }
    [Map("iInterestOnlyTerm")]
    public int? interestOnlyTerm { get; set; }
    [Map("fInterestOnlyLoading")]
    public int? interestOnlyLoading { get; set; }
    [Map("iDefaultLoanType")]
    public int? defaultLoanType { get; set; }
    [Map("iInitialOption")]
    public int? initialOption { get; set; }
    [Map("cTemplateID")]
    public string? templateID { get; set; }
    [Map("fMaxDiscount")]
    public decimal? maxDiscount { get; set; }
    [Map("bLinkedDebitCard")]
    public int? linkedDebitCard { get; set; }
    [Map("iAddedFromPisces")]
    public int? addedFromPisces { get; set; }
    [Map("fQualifyingRateMargin")]
    public decimal? qualifyingRateMargin { get; set; }
    [Map("iDefaultRollOverLoanType")]
    public int? defaultRollOverLoanType { get; set; }
    [Map("iProductGroup")]
    public int? productGroup { get; set; }
    [Map("iProductClass")]
    public int? productClass { get; set; }
    [Map("iProductLoanPurpose")]
    public int? productLoanPurpose { get; set; }
    [Map("loanPurpose")]
    public string? loanPurpose { get; set; }
    [Map("iRolloverRateIndex")]
    public int? rolloverRateIndex { get; set; }
}


