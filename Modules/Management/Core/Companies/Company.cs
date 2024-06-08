using RepoDb.Attributes;
using System.ComponentModel.DataAnnotations;

namespace LoanworksBackend.Modules.Management.Core.Companies;

[Map("tblCompany")]
public class Company
{
    [Key]
    [Map("ID")]
    public int Id { get; set; }
    [Map("iCompanyID")]
    [Required]
    public int CompanyId { get; set; } = default;
    [Map("cCompanyName")]
    public string? CompanyName { get; set; }
    [Map("cTradingAs")]
    public string? TradingAs { get; set; }
    [Map("iState")]
    public int? State { get; set; }
    [Map("cAddress1")]
    public string? Address1 { get; set; }
    [Map("cAddress2")]
    public string? Address2 { get; set; }
    [Map("cSuburb")]
    public string? Suburb { get; set; }
    [Map("cPostcode")]
    public string? Postcode { get; set; }
    [Map("cPhone")]
    public string? Phone { get; set; }
    [Map("cFax")]
    public string? Fax { get; set; }
    [Map("cEmail")]
    public string? Email { get; set; }
    [Map("cCompanyCode")]
    public string? CompanyCode { get; set; }
    [Map("cBankAccountCode")]
    public string? BankAccountCode { get; set; }
    [Map("cGSTCode")]
    public string? GSTCode { get; set; }
    [Map("varABN")]
    public string? VarABN { get; set; }
    [Map("varACN")]
    public string? VarACN { get; set; }
    [Map("cWebAgentOxIdentity")]
    public string? WebAgentOxIdentity { get; set; }
    [Map("cLoanWorksVersion")]
    public string? LoanWorksVersion { get; set; }
    [Map("cMailingAddress1")]
    public string? MailingAddress1 { get; set; }
    [Map("cMailingAddress2")]
    public string? MailingAddress2 { get; set; }
    [Map("cMailingSuburb")]
    public string? MailingSuburb { get; set; }
    [Map("cMailingPostcode")]
    public string? MailingPostcode { get; set; }
    [Map("iMailingState")]
    public int? MailingState { get; set; }
    [Map("cNameOfANZ")]
    public string? NameOfANZ { get; set; }
    [Map("cIDNumberOfANZ")]
    public string? IDNumberOfANZ { get; set; }
    [Map("cBankBSBNumber")]
    public string? BankBSBNumber { get; set; }
    [Map("cBankAccountNumber")]
    public string? BankAccountNumber { get; set; }
    [Map("cNameOfRemitter")]
    public string? NameOfRemitter { get; set; }
    [Map("cMYOBCardName")]
    public string? MYOBCardName { get; set; }
    [Map("cBankName_ABAExtract")]
    public string? BankName_ABAExtract { get; set; }
    [Map("cBankIdentifier_ABAExtract")]
    public string? BankIdentifier_ABAExtract { get; set; }
    [Map("cSequenceNumber_ABAExtract")]
    public string? SequenceNumber_ABAExtract { get; set; }
    [Map("cCommissionNarrative_ABAExtract")]
    public string? CommissionNarrative_ABAExtract { get; set; }
    [Map("cWebAddress")]
    public string? WebAddress { get; set; }
    [Map("iCompanyLogo1")]
    public int? CompanyLogo1 { get; set; }
    [Map("iCompanyLogo2")]
    public int? CompanyLogo2 { get; set; }
    [Map("iCompanyFooterLogo")]
    public int? CompanyFooterLogo { get; set; }
    [Map("iCompanyScreenLogo")]
    public int? CompanyScreenLogo { get; set; }
    [Map("cFeedBackEmail")]
    public string? FeedBackEmail { get; set; }
    [Map("cACL")]
    public string? ACL { get; set; }
    [Map("cOverseasPhone")]
    public string? OverseasPhone { get; set; }
    [Map("iCompanySmallScreenLogo")]
    public int? CompanySmallScreenLogo { get; set; }
    [Map("iMailingCountry")]
    public int? MailingCountry { get; set; }
    [Map("iTownCity")]
    public int? TownCity { get; set; }
    [Map("iCountry")]
    public int? Country { get; set; }
    [Map("iMailingTownCity")]
    public int? MailingTownCity { get; set; }
}

