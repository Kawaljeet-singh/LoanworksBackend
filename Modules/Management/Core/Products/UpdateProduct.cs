﻿using RepoDb.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoanworksBackend.Modules.Management.Core.Products;

public class UpdateProduct
{
    [Key]
    [Map("id")]
    public int Id { get; set; }
    [Map("loanClassId")]
    public int LoanClasssId { get; set; }
    [Map("productName")]
    public string? ProductName { get; set; }
    [Map("productCode")]
    public string? ProductCode { get; set; }
    [Map("funderId")]
    public int? FunderId { get; set; }
    [Map("funderProductName")]
    public string? FunderProductName { get; set; }
    [Map("funderProductCode")]
    public string? FunderProductCode { get; set; }
    [Map("productGroup")]
    public int? ProductGroup { get; set; }
    [Map("productClass")]
    public int? ProductClass { get; set; }
    [Map("status")]
    public bool? Status { get; set; }
    [Display(Name = "MinLoanAmount")]
    [Column(TypeName = "decimal(19, 2)")]
    [Map("minLoanAmount")]
    public decimal MinLoanAmount { get; set; }
    [Display(Name = "MaxLoanAmount")]
    [Column(TypeName = "decimal(19, 2)")]
    [Map("maxLoanAmount")]
    public decimal MaxLoanAmount { get; set; }
    [Map("maxTermLoanYears")]
    public int? MaxTermLoanYears { get; set; }
    [Map("maxTermLoanMonths")]
    public int? MaxTermLoanMonths { get; set; }
    [Map("maxDiscountRate")]
    public int? MaxDiscountRate { get; set; }
    [Map("initialBorrowerRate")]
    public int? InitialBorrowerRate { get; set; }
    [Map("repaymentType")]
    public int? RepaymentType { get; set; }
    [Map("creditRating")]
    public int? CreditRating { get; set; }
    [Map("defaultLoanType")]
    public int? DefaultLoanType { get; set; }
    [Map("productLoanPurpose")]
    public int? ProductLoanPurpose { get; set; }
    [Map("balloonPaymentAllowed")]
    public bool? BalloonPaymentAllowed { get; set; }
    [Display(Name = "BalloonMaxPercent")]
    [Column(TypeName = "decimal(19, 2)")]
    [Map("balloonMaxPercent")]
    public decimal BalloonMaxPercent { get; set; }
    [Display(Name = "BalloonMinPercent")]
    [Column(TypeName = "decimal(19, 2)")]
    [Map("balloonMinPercent")]
    public decimal BalloonMinPercent { get; set; }
    [Map("loyaltyProgramAllowed")]
    public bool? LoyaltyProgramAllowed { get; set; }
    [Map("LoyaltyProgramType")]
    public int? LoyaltyProgramType { get; set; }
    [Map("supplementaryCardHoldersMax")]
    public int? SupplementaryCardHoldersMax { get; set; }
}
