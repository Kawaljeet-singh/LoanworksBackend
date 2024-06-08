using RepoDb.Attributes;
using System.ComponentModel.DataAnnotations;

namespace LoanworksBackend.Modules.Applications.Core.FeeExceptions;

public class FeeException
{
    [Map("iAppID")]
    public int? ApplicationId { get; set; }
    [Map("cLoanName")]
    public string? LoanName { get; set; }
    [Map("iAppOwner")]
    [Required]
    public int ApplicationOwner { get; set; }
    [Map("dAppDate")]
    public DateTime? ApplicationDate { get; set; }
    [Map("cFirstName")]
    public string? FirstName { get; set; }
    [Map("cSurname")]
    public string? Surname { get; set; }
    [Map("iOrgID")]
    public int? OrgId { get; set; }
    [Map("cOrgName")]
    public string? OrgName { get; set; }
    [Map("dWithSolicitor")]
    public DateTime? WithSolicitor { get; set; }  
    [Map("dSettled")] 
    public DateTime? Settled { get; set; }
    [Map("iProductAppID")]
    [Required]
    public int ProductAppId { get; set; } = default;
    [Map("fProductFees")]
    public float? ProductFees { get; set; }
    [Map("fProductTrans")]
    public float? ProductTrans { get; set; }
    [Map("iLegalsAppID")]
    [Required]
    public int LegalsAppId { get; set; } = default;
    public float? SumLegalFees { get; set; }
    public float? SumLegalTransAmt { get; set; }
    [Map("iValuationAppID")]
    public int ValuationAppId { get; set; } = default;
    public float? ValuationFee { get; set; }
    public float? ValuationSumTransAmt { get; set; }
}
