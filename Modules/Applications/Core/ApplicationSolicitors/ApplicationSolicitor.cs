using RepoDb.Attributes;
using System.ComponentModel.DataAnnotations;

namespace LoanworksBackend.Modules.Applications.Core.ApplicationSolicitors;

public class ApplicationSolicitor
{
    [Key]
    [Map("ID")]
    public int Id { get; set; }
    [Map("iSolicitorID")]
    [Required]
    public int SolicitorId { get; set; } = default;
    [Map("cSolicitorPracticeName")]
    public string? SolicitorPracticeName { get; set; }
    [Map("cSolicitorAddress1")]
    public string? SolicitorAddress1 { get; set; }
    [Map("cSolicitorAddress2")]
    public string? SolicitorAddress2 { get; set; }
    [Map("iSolicitorAddressState")]
    public int? SolicitorAddressState { get; set; }
    [Map("cSolicitorAddressSuburb")]
    public string? SolicitorAddressSuburb { get; set; }
    [Map("cSolicitorAddressPostCode")]
    public string? SolicitorAddressPostCode { get; set; }
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
    [Map("cSolicitorGLAccountCode")]
    public string? SolicitorGLAccountCode { get; set; }
    [Map("varSolicitorABN")]
    public string? VarSolicitorABN { get; set; }
    [Map("iRequestMessageType")]
    public int? RequestMessageType { get; set; }
    [Map("cInterfaceUserName")]
    public string? InterfaceUserName { get; set; }
    [Map("cInterfacePassword")]
    public string? InterfacePassword { get; set; }
    [Map("cSolRequestTargetIdentity")]
    public string? SolRequestTargetIdentity { get; set; }
    [Map("iSolicitorTownCity")]
    public int? SolicitorTownCity { get; set; }
    [Map("iSolicitorCountry")]
    public int? SolicitorCountry { get; set; }
    [Map("cSolicitorBankAccountName")]
    public string? SolicitorBankAccountName { get; set; }
    [Map("cSolicitorBankAccountBSB")]
    public string? SolicitorBankAccountBSB { get; set; }
    [Map("cSolicitorBankAccountNo")]
    public string? SolicitorBankAccountNo { get; set; }
}


