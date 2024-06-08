using RepoDb.Attributes;

namespace LoanworksBackend.Modules.Management.Core.Security;

public class UserTaskAccessExtract
{
    public string Name { get; set; } = default!;
    public string Role { get; set; } = default!;
    [Map("Allows change of ownership")]
    public int AllowsChangeOfOwnership { get; set; }
    [Map("Test")]
    public int Test { get; set; }
    [Map("Allows to see Unassigned Enquires")]
    public int AllowsToSeeUnassignedEnquires { get; set; }
    [Map("Allows to view multiple Assigned Enquires")]
    public int AllowsToViewMultipleAssignedEnquires { get; set; }
    [Map("Allows change of branch")]
    public int AllowsChangeOfBranch { get; set; }
    [Map("Can update an enquiry")]
    public int Canupdateanenquiry { get; set; }
    [Map("Can read an enquiry")]
    public int Canreadanenquiry { get; set; }
    [Map("Set the user as the owner during creation of an enquiry or application")]
    public int Settheuserastheownerduringcreationofanenquiryorapplication { get; set; }
    [Map("Can update or delete a user created history note")]
    public int Canupdateordeleteausercreatedhistorynote { get; set; }
    [Map("Allowed to Move Enquiry to Application")]
    public int AllowedtoMoveEnquirytoApplication { get; set; }
    [Map("App - Allows change of ownership")]
    public int AppAllowschangeofownership { get; set; }
    [Map("App - Allows to see Unassigned Applications")]
    public int AppAllowstoseeUnassignedApplications { get; set; }
    [Map("App - Can read an application")]
    public int AppCanreadanapplication { get; set; }
    [Map("App - Can update or delete a user created history note")]
    public int AppCanupdateordeleteausercreatedhistorynote { get; set; }
    [Map("App - Allows to view multiple Assigned Applications")]
    public int AppAllowstoviewmultipleAssignedApplications { get; set; }
    [Map("App - Can update an Application")]
    public int AppCanupdateanApplication { get; set; }
    [Map("App - Allowed to Move Application to Settlement")]
    public int AppAllowedtoMoveApplicationtoSettlement { get; set; }
    [Map("Set - Finalised Applications")]
    public int SetFinalisedApplications { get; set; }
    [Map("Set - Allows to view multiple Assigned Settlement")]
    public int SetAllowstoviewmultipleAssignedSettlement { get; set; }
    [Map("Set - Allows to see Unassigned Settlement")]
    public int testing { get; set; }
    [Map("Set - Undo Finalised Settlements")]
    public int SetUndoFinalisedSettlements { get; set; }
    [Map("Set - Can change Applications")]
    public int SetCanchangeApplications { get; set; }
    [Map("Set - Allows change of ownership")]
    public int SetAllowschangeofownership { get; set; }
    [Map("Man - Modify National Introducer")]
    public int ManModifyNationalIntroducer { get; set; }
    [Map("Man - Modify Local Introducer")]
    public int ManModifyLocalIntroducer { get; set; }
    [Map("Man - Modify User")]
    public int ManModifyUser { get; set; }
    [Map("Man - Delete User")]
    public int ManDeleteUser { get; set; }
    [Map("Man - Modify Data")]
    public int ManModifyData { get; set; }
    [Map("Man - Modify Profile")]
    public int ManModifyProfile { get; set; }
    [Map("Man - Modify Branch")]
    public int ManModifyBranch { get; set; }
    [Map("User not restricted by Program Guidelines")]
    public int UsernotrestrictedbyProgramGuidelines { get; set; }
    [Map("App - Allows change of branch")]
    public int AppAllowschangeofbranch { get; set; }
    [Map("App - Change Application Status")]
    public int AppChangeApplicationStatus { get; set; }
    [Map("Enq - Allows creation of enquiry letters")]
    public int EnqAllowscreationofenquiryletters { get; set; }
    [Map("Enq - Allows sending of enquiry letters")]
    public int EnqAllowssendingofenquiryletters { get; set; }
    [Map("App - Allows creation of application letters")]
    public int AppAllowscreationofapplicationletters { get; set; }
    [Map("App - Allows sending of application letters")]
    public int AppAllowssendingofapplicationletters { get; set; }
    [Map("Man - Allows to display credit transactions")]
    public int ManAllowstodisplaycredittransactions { get; set; }
    [Map("Man - Allows to update Banking Transactions")]
    public int ManAllowstoupdateBankingTransactions { get; set; }
    [Map("Man - Allows to display debit transactions")]
    public int ManAllowstodisplaydebittransactions { get; set; }
    [Map("Bank - Display branches")]
    public int BankDisplaybranches { get; set; }
    [Map("Enq - Edit Other User Records")]
    public int EnqEditOtherUserRecords { get; set; }
    [Map("App - Edit Other User Records")]
    public int AppEditOtherUserRecords { get; set; }
    [Map("Set - Edit Other User Records")]
    public int SetEditOtherUserRecords { get; set; }
    [Map("Set - Tracker By Region")]
    public int SetTrackerByRegion { get; set; }
    [Map("Bank - Display Secure Transactions")]
    public int BankDisplaySecureTransactions { get; set; }
    [Map("App - can change borrower rate of a product")]
    public int Appcanchangeborrowerrateofaproduct { get; set; }
    [Map("Set - Can create a settlement letter")]
    public int SetCancreateasettlementletter { get; set; }
    [Map("set - Can send a settlement letter")]
    public int SetCansendasettlementletter { get; set; }
    [Map("SET - Discharge / Payout Loan")]
    public int SetDischargePayoutLoan { get; set; }
    [Map("SET - Allowed To Unlock Applications")]
    public int SetAllowedToUnlockApplications { get; set; }
    [Map("SUBORG - Allowed to Update Sub Originator Codes")]
    public int SuborgAllowedtoUpdateSubOriginatorCodes { get; set; }
    [Map("PAY - Allowed to Update Payment Structures")]
    public int PayAllowedtoUpdatePaymentStructures { get; set; }
    [Map("Man - Modify Workflow")]
    public int ManModifyWorkflow { get; set; }
    [Map("App-Using Capacity Calculator")]
    public int AppUsingCapacityCalculator { get; set; }
    [Map("Allow Access to OX Interface")]
    public int AllowAccesstoOXInterface { get; set; }
    [Map("Allow access to Outlook")]
    public int AllowaccesstoOutlook { get; set; }
    [Map("Allow Access to Credit Advantage Interface")]
    public int AllowAccesstoCreditAdvantageInterface { get; set; }
    [Map("Allow Access to change other Applications Consultant")]
    public int AllowAccesstochangeotherApplicationsConsultant { get; set; }
    [Map("Allow Access to delete other Enquiries")]
    public int AllowAccesstodeleteotherEnquiries { get; set; }
    [Map("Allow Access to delete other Applications")]
    public int AllowAccesstodeleteotherApplications { get; set; }
    [Map("Allow Access to override the originator margin")]
    public int AllowAccesstooverridetheoriginatormargin { get; set; }
    [Map("Display Commission Overrides section in Commission screen")]
    public int DisplayCommissionOverridessectioninCommissionscreen { get; set; }
    [Map("Potentially display option to email invoices")]
    public int Potentiallydisplayoptiontoemailinvoices { get; set; }
    [Map("Potentially display option to quick view invoices")]
    public int Potentiallydisplayoptiontoquickviewinvoices { get; set; }
    [Map("Potentially display option to print invoices")]
    public int Potentiallydisplayoptiontoprintinvoices { get; set; }
    [Map("Potentially display option to send invoices to open exchange")]
    public int Potentiallydisplayoptiontosendinvoicestoopenexchange { get; set; }
    [Map("Allow Access to View Loan Balance")]
    public int AllowAccesstoViewLoanBalance { get; set; }
    [Map("Allow Access to Edit Loan Balance")]
    public int AllowAccesstoEditLoanBalance { get; set; }
    [Map("Can view application via enquiry tracker")]
    public int Canviewapplicationviaenquirytracker { get; set; }
    [Map("User can modify product fee")]
    public int Usercanmodifyproductfee { get; set; }
    [Map("User can change the fee collect flag.")]
    public int Usercanchangethefeecollectflag { get; set; }
    [Map("Allow Access to Recipient Sub Originator code")]
    public int AllowAccesstoRecipientSubOriginatorcode { get; set; }
    [Map("Allow Access to Recipient Payment Structures")]
    public int AllowAccesstoRecipientPaymentStructures { get; set; }
    [Map("Allow Access to Recipient Payment Parameters")]
    public int AllowAccesstoRecipientPaymentParameters { get; set; }
    [Map("Allow Access to Recipient Commission Report Settings")]
    public int AllowAccesstoRecipientCommissionReportSettings { get; set; }
    [Map("Allow Access to Introducer Relationships")]
    public int AllowAccesstoIntroducerRelationships { get; set; }
    [Map("Allow Access to Introducer Branch Management")]
    public int AllowAccesstoIntroducerBranchManagement { get; set; }
    [Map("Allow Access to Introducer")]
    public int AllowAccesstoIntroducer { get; set; }
    [Map("Allow Access to View Introducer Relationships")]
    public int AllowAccesstoViewIntroducerRelationships { get; set; }
    [Map("Allow Access to View Introducer Branch Management")]
    public int AllowAccesstoViewIntroducerBranchManagement { get; set; }
    [Map("Allow Access to View Introducer Commission Details")]
    public int AllowAccesstoViewIntroducerCommissionDetails { get; set; }
    [Map("Allow Access to View Introducer WEB Broker")]
    public int AllowAccesstoViewIntroducerWEBBroker { get; set; }
    [Map("Allow Access to View Account Code Details")]
    public int AllowAccesstoViewAccountCodeDetails { get; set; }
    [Map("Allow Access to View Introducer Banking Details")]
    public int AllowAccesstoViewIntroducerBankingDetails { get; set; }
    [Map("Allow Access to View Introducer Insurance Details")]
    public int AllowAccesstoViewIntroducerInsuranceDetails { get; set; }
    [Map("Allow Access to View Introducer Accredition Details")]
    public int AllowAccesstoViewIntroducerAccreditionDetails { get; set; }
    [Map("Allow Access to View Sub Original Code")]
    public int AllowAccesstoViewSubOriginalCode { get; set; }
    [Map("Allow Access to View Commission Report Settings")]
    public int AllowAccesstoViewCommissionReportSettings { get; set; }
    [Map("Allow Access to View Commission Payment Structure")]
    public int AllowAccesstoViewCommissionPaymentStructure { get; set; }
    [Map("Allow Access to View Commission Payment Parameters")]
    public int AllowAccesstoViewCommissionPaymentParameters { get; set; }
    [Map("Allow Access to View Introducer Audit Screen")]
    public int AllowAccesstoViewIntroducerAuditScreen { get; set; }
    [Map("Allow Access to Introducer Status")]
    public int AllowAccesstoIntroducerStatus { get; set; }
    [Map("Allow Access to Organisation Introducer Profile")]
    public int AllowAccesstoOrganisationIntroducerProfile { get; set; }
    [Map("Display Commission Payments section in Commission screen")]
    public int DisplayCommissionPaymentssectioninCommissionscreen { get; set; }
    [Map("Display Bank Account Name in Invoice Transmission")]
    public int DisplayBankAccountNameinInvoiceTransmission { get; set; }
    [Map("Can Upload an application letter")]
    public int CanUploadanapplicationletter { get; set; }
    [Map("Can View an application letter")]
    public int CanViewanapplicationletter { get; set; }
    [Map("Can Upload a settlement letter")]
    public int CanUploadasettlementletter { get; set; }
    [Map("Can View a settlement letter")]
    public int CanViewasettlementletter { get; set; }
    [Map("Can unlock discharged application")]
    public int Canunlockdischargedapplication { get; set; }
    [Map("Enable attachment for canncelled deal")]
    public int Enableattachmentforcanncelleddeal { get; set; }
    [Map("Enable to change product status")]
    public int Enabletochangeproductstatus { get; set; }
    [Map("Enable to change funder status")]
    public int Enabletochangefunderstatus { get; set; }
    [Map("Can Add/Modify/Delete Builder")]
    public int CanAddModifyDeleteBuilder { get; set; }
    [Map("Can View General Builder Details")]
    public int CanViewGeneralBuilderDetails { get; set; }
    [Map("Can View Builder Contact Details")]
    public int CanViewBuilderContactDetails { get; set; }
    [Map("Can View Builder Banking Details")]
    public int CanViewBuilderBankingDetails { get; set; }
    [Map("Can View Web Access Details")]
    public int CanViewWebAccessDetails { get; set; }
    [Map("Can Upload an enquiry letter")]
    public int CanUploadanenquiryletter { get; set; }
    [Map("Can view an enquiry letter")]
    public int Canviewanenquiryletter { get; set; }
    [Map("Enq - Can change borrower rate of a product")]
    public int EnqCanchangeborrowerrateofaproduct { get; set; }
    [Map("Enq - Allow Access to OX Interface")]
    public int EnqAllowAccesstoOXInterface { get; set; }
    [Map("Enquiry - Allow Access to CRA Interface.")]
    public int EnquiryAllowAccesstoCRAInterface { get; set; }
    [Map("Enq - Allow Access to override the originator margin")]
    public int EnqAllowAccesstooverridetheoriginatormargin { get; set; }
    [Map("Enq - Allow Access to Commission Override Sub-menu")]
    public int EnqAllowAccesstoCommissionOverrideSubmenu { get; set; }
    [Map("Enq - User can modify product fee")]
    public int EnqUsercanmodifyproductfee { get; set; }
    [Map("Enq - User can change the fee collect flag.")]
    public int EnqUsercanchangethefeecollectflag { get; set; }
    [Map("Enable attachment for not proceeding deal.")]
    public int Enableattachmentfornotproceedingdeal { get; set; }
    [Map("Enq - Change Enquiry Status")]
    public int EnqChangeEnquiryStatus { get; set; }
    [Map("Can Only View Own User Record")]
    public int CanOnlyViewOwnUserRecord { get; set; }
    [Map("Can View User Banking Details")]
    public int CanViewUserBankingDetails { get; set; }
    [Map("Can Edit User Banking Details")]
    public int CanEditUserBankingDetails { get; set; }
    [Map("Enq - Can Open Application from Tracker")]
    public int EnqCanOpenApplicationfromTracker { get; set; }
    [Map("Enq - Switch Enquiry Check on for Add Enquiry")]
    public int EnqSwitchEnquiryCheckonforAddEnquiry { get; set; }
    [Map("Enq - Auto Assign Application")]
    public int EnqAutoAssignApplication { get; set; }
    [Map("Enq - Display other user enquiry in enquiry search")]
    public int EnqDisplayotheruserenquiryinenquirysearch { get; set; }
    [Map("Enq - Display fees on Summary")]
    public int EnqDisplayfeesonSummary { get; set; }
    [Map("Enq - Can view Application in Progress from Tracker")]
    public int EnqCanviewApplicationinProgressfromTracker { get; set; }
    [Map("Enq - Can view Cancelled Application from Tracker")]
    public int EnqCanviewCancelledApplicationfromTracker { get; set; }
    [Map("Enq - Can view Settled Application from Tracker")]
    public int EnqCanviewSettledApplicationfromTracker { get; set; }
    [Map("Enq - Allow access to Borrower")]
    public int EnqAllowaccesstoBorrower { get; set; }
    [Map("Enq - Allow access to Corporate")]
    public int EnqAllowaccesstoCorporate { get; set; }
    [Map("Enq - Allow access to Security")]
    public int EnqAllowaccesstoSecurity { get; set; }
    [Map("Enq - Allow access to Attachment")]
    public int EnqAllowaccesstoAttachment { get; set; }
    [Map("Allow Access to Application Funds Position Sub-menu")]
    public int AllowAccesstoApplicationFundsPositionSubmenu { get; set; }
    [Map("Allow to add ad hoc fee to application and product")]
    public int Allowtoaddadhocfeetoapplicationandproduct { get; set; }
    [Map("Can create restricted note")]
    public int Cancreaterestrictednote { get; set; }
    [Map("Can View restricted note")]
    public int CanViewrestrictednote { get; set; }
    [Map("Allow add/update Credit summary")]
    public int AllowaddupdateCreditsummary { get; set; }
    [Map("Allow Access to Application Serviceability Sub-menu")]
    public int AllowAccesstoApplicationServiceabilitySubmenu { get; set; }
    [Map("Allow user to delete application task")]
    public int Allowusertodeleteapplicationtask { get; set; }
    [Map("Allow user to delete application fee")]
    public int Allowusertodeleteapplicationfee { get; set; }
    [Map("Display Customer Match Across Hierarchy")]
    public int DisplayCustomerMatchAcrossHierarchy { get; set; }
    [Map("Limit Customer Search to Display Exact Match Only")]
    public int LimitCustomerSearchtoDisplayExactMatchOnly { get; set; }
    [Map("Limit Customer Search to Display Existing Business Only")]
    public int LimitCustomerSearchtoDisplayExistingBusinessOnly { get; set; }
    [Map("Limit Customer Search to Display Hierarchical Results Only")]
    public int LimitCustomerSearchtoDisplayHierarchicalResultsOnly { get; set; }
    [Map("Limit Customer Search to Display Customer Ownership Only")]
    public int LimitCustomerSearchtoDisplayCustomerOwnershipOnly { get; set; }
    [Map("Can Create Enquiry from Dashboard")]
    public int CanCreateEnquiryfromDashboard { get; set; }
    [Map("Can Create Application from Dashboard")]
    public int CanCreateApplicationfromDashboard { get; set; }
    [Map("Can View Customer Ownership")]
    public int CanViewCustomerOwnership { get; set; }
    [Map("Allow Update Preferred Marketing")]
    public int AllowUpdatePreferredMarketing { get; set; }
    [Map("Can Import Customers via Marketing Event")]
    public int CanImportCustomersviaMarketingEvent { get; set; }
    [Map("View other users Today's Tasks")]
    public int ViewotherusersTodaysTasks { get; set; }
    [Map("Allow to delete enquiry task")]
    public int Allowtodeleteenquirytask { get; set; }
    [Map("Modify Banking Transactions")]
    public int ModifyBankingTransactions { get; set; }
    [Map("Can Update a Program")]
    public int CanUpdateaProgram { get; set; }
    [Map("Can delete a Group/Program")]
    public int CandeleteaGroupProgram { get; set; }
    [Map("Can Copy a Program")]
    public int CanCopyaProgram { get; set; }
    [Map("Can Active/Deactive a Program")]
    public int CanActiveDeactiveaProgram { get; set; }
    [Map("Can add new Group/Program")]
    public int CanaddnewGroupProgram { get; set; }
    [Map("Can Change Notes Status")]
    public int CanChangeNotesStatus { get; set; }
    [Map("Can return application to enquiry")]
    public int Canreturnapplicationtoenquiry { get; set; }
    [Map("Can Update Enquiry Tasks after Enquiry Move to Application")]
    public int CanUpdateEnquiryTasksafterEnquiryMovetoApplication { get; set; }
    [Map("Can Post Rate Changes")]
    public int CanPostRateChanges { get; set; }
    [Map("Allowed to Edit Locked Applications")]
    public int AllowedtoEditLockedApplications { get; set; }
    [Map("Allowed to select Outside Rate Matrix")]
    public int AllowedtoselectOutsideRateMatrix { get; set; }
    [Map("View Contact Details")]
    public int ViewContactDetails { get; set; }
    [Map("View General Details")]
    public int ViewGeneralDetails { get; set; }
    [Map("View Introducer Groups")]
    public int ViewIntroducerGroups { get; set; }
    [Map("View linked Users")]
    public int ViewlinkedUsers { get; set; }
    [Map("Can Update Product Loan Grade Rate Matrix")]
    public int CanUpdateProductLoanGradeRateMatrix { get; set; }
    [Map("Can only update Originator Margin")]
    public int CanonlyupdateOriginatorMargin { get; set; }
    [Map("Allow View Ox messages in App Ox Message")]
    public int AllowViewOxmessagesinAppOxMessage { get; set; }
    [Map("Allow Validate App Funder Submission")]
    public int AllowValidateAppFunderSubmission { get; set; }
    [Map("Allow submit App Funder Submission")]
    public int AllowsubmitAppFunderSubmission { get; set; }
    [Map("Can View OX Messages for Full Approval")]
    public int CanViewOXMessagesforFullApproval { get; set; }
    [Map("Can Validate AFS Application for Full Approval")]
    public int CanValidateAFSApplicationforFullApproval { get; set; }
    [Map("Can submit Application to AFS for Full Approval")]
    public int CansubmitApplicationtoAFSforFullApproval { get; set; }
    [Map("Display Disbursements sub-menu")]
    public int DisplayDisbursementssubmenu { get; set; }
    [Map("App- Can override Product Maximum Discount Rate")]
    public int AppCanoverrideProductMaximumDiscountRate { get; set; }
    [Map("Enq- Can override Product Maximum Discount Rate")]
    public int EnqCanoverrideProductMaximumDiscountRate { get; set; }
    [Map("Can only view Call List button in Outbound Calls screen")]
    public int CanonlyviewCallListbuttoninOutboundCallsscreen { get; set; }
    [Map("Enq - Allow Automated Product Rate/Margin Calculation to be overridden")]
    public int EnqAllowAutomatedProductRateMarginCalculationtobeoverridden { get; set; }
    [Map("App - Allow Automated Product Rate/Margin Calculation to be overridden")]
    public int AppAllowAutomatedProductRateMarginCalculationtobeoverridden { get; set; }
    [Map("Can request a Product Catalogue Update")]
    public int CanrequestaProductCatalogueUpdate { get; set; }
    [Map("Display Lodgement to Lender Submenu")]
    public int DisplayLodgementtoLenderSubmenu { get; set; }
    [Map("Enq - Can Request a ValEx Valuation")]
    public int EnqCanRequestaValExValuation { get; set; }
    [Map("Enq - Cancel/Delete Valuation Request")]
    public int EnqCancelDeleteValuationRequest { get; set; }
    [Map("Enq - Override ValEx Valuer Allocation")]
    public int EnqOverrideValExValuerAllocation { get; set; }
    [Map("App - Can Request a ValEx Valuation")]
    public int AppCanRequestaValExValuation { get; set; }
    [Map("App - Cancel/Delete Valuation Request")]
    public int AppCancelDeleteValuationRequest { get; set; }
    [Map("App - Override ValEx Valuer Allocation")]
    public int AppOverrideValExValuerAllocation { get; set; }
    [Map("Allow Formally Approved Application to be Updated")]
    public int AllowFormallyApprovedApplicationtobeUpdated { get; set; }
    [Map("App - Can Override Restriction On Number Of Times OX Message Can Be Sent")]
    public int AppCanOverrideRestrictionOnNumberOfTimesOXMessageCanBeSent { get; set; }
    [Map("Add/Update Non-valex valuations")]
    public int AddUpdateNonvalexvaluations { get; set; }
    [Map("Display Branch Override in Commission Override Screen")]
    public int DisplayBranchOverrideinCommissionOverrideScreen { get; set; }
    [Map("Can Override Reconciled Constraint")]
    public int CanOverrideReconciledConstraint { get; set; }
    [Map("Can View the Product Features Section")]
    public int CanViewtheProductFeaturesSection { get; set; }
    [Map("Can View Borrower – Personal Details section")]
    public int CanViewBorrowerPersonalDetailssection { get; set; }
    [Map("Can View Borrower – ID & Residency Details section")]
    public int CanViewBorrowerIDResidencyDetailssection { get; set; }
    [Map("Can View Borrower – Address section(including current, previous, mailing, prior)")]
    public int CanViewBorrowerAddresssection { get; set; }
    [Map("Can View Borrower – Employment Details section(including current, previous)")]
    public int CanViewBorrowerEmploymentDetailssection { get; set; }
    [Map("Can Add/Update Borrower – Personal Details section")]
    public int CanAddUpdateBorrowerPersonalDetailssection { get; set; }
    [Map("Can Add/Update Borrower – ID & Residency Details section")]
    public int CanAddUpdateBorrowerIDResidencyDetailssection { get; set; }
    [Map("Can Add/Update Borrower – Address section(including current, previous, post settlement, mailing, prior)")]
    public int CanAddUpdateBorrowerAddresssection { get; set; }
    [Map("Can Add/Update Borrower – Employment Details section(including current, previous)")]
    public int CanAddUpdateBorrowerEmploymentDetailssection { get; set; }
    [Map("Can Send an Instruct Solicitor message")]
    public int CanSendanInstructSolicitormessage { get; set; }
    [Map("Can Send a Resubmit Matter Request message")]
    public int CanSendaResubmitMatterRequestmessage { get; set; }
    [Map("Can OverrideGovernment Fees and Charges")]
    public int CanOverrideGovernmentFeesandCharges { get; set; }
    [Map("Can Add/Modify/Delete Application Liability")]
    public int CanAddModifyDeleteApplicationLiability { get; set; }
    [Map("Can Add/Modify/Delete Application Income")]
    public int CanAddModifyDeleteApplicationIncome { get; set; }
    [Map("Can Add/Modify/Delete Application Asset")]
    public int CanAddModifyDeleteApplicationAsset { get; set; }
    [Map("Can Adjust Imported Data Records")]
    public int CanAdjustImportedDataRecords { get; set; }
    [Map("Can Edit System Imported")]
    public int CanEditSystemImported { get; set; }
    [Map("Can see other User’s in same profile(Global + Cabinet Tracker)")]
    public int CanseeotherUsersinsameprofile { get; set; }
    [Map("Can see other Profiles(Global + Cabinet Tracker)")]
    public int CanseeotherProfiles { get; set; }
    [Map("Can see ALL Profiles option(Global + Cabinet Tracker)")]
    public int CanseeALLProfilesoption { get; set; }
    [Map("Can see Unassigned(Global + Cabinet Tracker)")]
    public int CanseeUnassigned { get; set; }
    [Map("Can see ALL Business(Global Tracker)")]
    public int CanseeALLBusiness { get; set; }
    [Map("Can see Restricted applications")]
    public int CanseeRestrictedapplications { get; set; }
    [Map("Can see Restricted settlements")]
    public int CanseeRestrictedsettlements { get; set; }
    [Map("Can change Portal Locked flag")]
    public int CanchangePortalLockedflag { get; set; }
    [Map("Can update Customer/Member Number")]
    public int CanupdateCustomerMemberNumber { get; set; }
    [Map("Can Enter Product Discount Rate")]
    public int CanEnterProductDiscountRate { get; set; }
    [Map("Can view Cash Flow")]
    public int CanviewCashFlow { get; set; }
    [Map("Can Undo Declined Credit Decision")]
    public int CanUndoDeclinedCreditDecision { get; set; }
    [Map("Can Set Status On Hold")]
    public int CanSetStatusOnHold { get; set; }
}