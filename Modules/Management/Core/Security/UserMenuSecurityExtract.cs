namespace LoanworksBackend.Modules.Management.Core.Security;

/// <summary>
/// Contains all the fields on the extract of user menu security config
/// </summary>
public class UserMenuSecurityExtract
{
    public string UserName { get; set; } = default!;
    public string Role { get; set; } = default!;
    public int MenuSecurity { get; set; }
    public int Workflow { get; set; }
    public int BankingList { get; set; }
    public int ABLConnect { get; set; }
    public int ProductGuide { get; set; }
    public int D365Export { get; set; }
    public int AccountsExport { get; set; }
    public int Gadens { get; set; }
    public int ResimacLoanEnquiry { get; set; }
    public int ABR { get; set; }
    public int CommissionSettingReport { get; set; }
    public int ContactList { get; set; }
    public int AddNewEnquiry { get; set; }
    public int SearchforEnquiry { get; set; }
    public int CopyApplication { get; set; }
    public int AddNewApplication { get; set; }
    public int SearchForApplication { get; set; }
    public int SearchForSettlement { get; set; }
    public int Settlement { get; set; }
    public int BankingInput { get; set; }
    public int BankReconciliation { get; set; }
    public int Users { get; set; }
    public int Profiles { get; set; }
    public int Organizations { get; set; }
    public int DataMaintenance { get; set; }
    public int Introducers { get; set; }
    public int Baycorp { get; set; }
    public int SubsidyBatch { get; set; }
    public int DeleteApplication { get; set; }
    public int Activityreport { get; set; }
    public int PostBalance { get; set; }
    public int WorkFlowReport { get; set; }
    public int InterfaceControls { get; set; }
    public int CreditCardInput { get; set; }
    public int ProposedPayment { get; set; }
    public int Preparation { get; set; }
    public int Calculation { get; set; }
    public int ReleaseCommissionRun { get; set; }
    public int GenerateInvoices { get; set; }
    public int InvoiceTransmission { get; set; }
    public int ManualCommissionRun { get; set; }
    public int TransactionManagement { get; set; }
    public int GenerateBankTrans { get; set; }
    public int JobStatus { get; set; }
    public int ABAExport { get; set; }
    public int MicropayExport { get; set; }
    public int CommissionExport { get; set; }
    public int BooksizeManagement { get; set; }
    public int TrailQualification { get; set; }
    public int ReleaseHeldTransactions { get; set; }
    public int DecisioningReport { get; set; }
    public int CopyEnquiry { get; set; }
    public int DeleteEnquiry { get; set; }
    public int Documents { get; set; }
    public int NewZealandCompaniesRegister { get; set; }
    public int OutboundCalls { get; set; }
    public int ImportApplication { get; set; }
    public int ING { get; set; }
    public int CustomerSearch { get; set; }
    public int CreateCustomer { get; set; }
    public int EventReport { get; set; }
    public int Roles { get; set; }
    public int InvoicedCommissions { get; set; }
    public int RepaymentCalculator { get; set; }
    public int ComparisonCalculator { get; set; }
    public int EventAttendees { get; set; }
    public int EventManager { get; set; }
    public int Products { get; set; }
    public int Funders { get; set; }
    public int Advantedge { get; set; }
    public int ACTRevenueOffice { get; set; }
    public int ASIC { get; set; }
    public int AustralianBusinessRegister { get; set; }
    public int AustralianTaxationOffice { get; set; }
    public int GoogleMaps { get; set; }
    public int MFAA { get; set; }
    public int NSWOfficeofStateRevenue { get; set; }
    public int QLDOfficeofStateRevenue { get; set; }
    public int RevenueSA { get; set; }
    public int SROVIC { get; set; }
    public int WAOfficeofStateRevenue { get; set; }
    public int Whereis { get; set; }
    public int WhitePages { get; set; }
    public int YellowPages { get; set; }
    public int TASOfficeofStateRevenue { get; set; }
    public int ReassignCustomers { get; set; }
    public int GlobalSettings { get; set; }
    public int CollectionsTracker { get; set; }
    public int ArrearsImport { get; set; }
    public int DLAManagement { get; set; }
    public int ProgramManagement { get; set; }
    public int Branding { get; set; }
    public int BankStatementPayments { get; set; }
}
