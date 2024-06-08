using RepoDb.Attributes;

namespace LoanworksBackend.Modules.Management.Core.Security;

/// <summary>
/// Summary record for the profile task access configuration for extract to excel
/// </summary>
public class ProfileTaskAccessExtract
{
    public string TaskOptions { get; set; } = default!;
    public int Accounts { get; set; }
    public int Administrator { get; set; }
    [Map("Application Admin")]
    public int ApplicationAdmin { get; set; }
    public int BDM { get; set; }
    [Map("Credit Administrator")]
    public int CreditAdministrator { get; set; }
    [Map("Credit Manager")]
    public int CreditManager { get; set; }
    [Map("Credit QA Read Only")]
    public int CreditQAReadOnly { get; set; }
    [Map("Credit Underwriter")]
    public int CreditUnderwriter { get; set; }
    [Map("Introducer Maintenance")]
    public int IntroducerMaintenance { get; set; }
    [Map("Loan Coordinator")]
    public int LoanCoordinator { get; set; }
    [Map("Loan Support and Application Administration Manager")]
    public int LoanSupportandApplicationAdministrationManager { get; set; }
    [Map("Loan Support and Application Administration Manager with Commissions Invoices")]
    public int LoanSupportandApplicationAdministrationManagerwithCommissionsInvoices { get; set; }
    [Map("Loan Support and Application Administration Officer")]
    public int LoanSupportandApplicationAdministrationOfficer { get; set; }
    [Map("Loan Support and Application Administration Officer Direct")]
    public int LoanSupportandApplicationAdministrationOfficerDirect { get; set; }
    [Map("Loan Support and Application Administration Officer with Commissions Invoices")]
    public int LoanSupportandApplicationAdministrationOfficerwithCommissionsInvoices { get; set; }
    [Map("Loan Support and Application Administration Team Leader")]
    public int LoanSupportandApplicationAdministrationTeamLeader { get; set; }
    [Map("Loan Support and Application Administration Team Leader Direct")]
    public int LoanSupportandApplicationAdministrationTeamLeaderDirect { get; set; }
    [Map("Loan Support and Application Administration Team Leader with Commissions Invoices")]
    public int LoanSupportandApplicationAdministrationTeamLeaderwithCommissionsInvoices { get; set; }
    [Map("No Access")]
    public int NoAccess { get; set; }
    [Map("Product Maintenance")]
    public int ProductMaintenance { get; set; }
    [Map("Sales Manager")]
    public int SalesManager { get; set; }
    [Map("Sales Manager Direct")]
    public int SalesManagerDirect { get; set; }
    [Map("Sales Manager Direct with Workflow Access")]
    public int SalesManagerDirectwithWorkflowAccess { get; set; }
    [Map("Sales Manager New Zealand")]
    public int SalesManagerNewZealand { get; set; }
    [Map("Sales Officer")]
    public int SalesOfficer { get; set; }
    [Map("Sales Officer Direct")]
    public int SalesOfficerDirect { get; set; }
    [Map("Senior Settlement Officer")]
    public int SeniorSettlementOfficer { get; set; }
    [Map("Settlement Officer")]
    public int SettlementOfficer { get; set; }
    [Map("Settlement Officer New Zealand")]
    public int SettlementOfficerNewZealand { get; set; }
    [Map("Settlement Team Leader")]
    public int SettlementTeamLeader { get; set; }
    [Map("Settlement Team Leader New Zealand")]
    public int SettlementTeamLeaderNewZealand { get; set; }
    [Map("Variations Team Member")]
    public int VariationsTeamMember { get; set; }
}
