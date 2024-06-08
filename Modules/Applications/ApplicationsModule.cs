using LoanworksBackend.Extensions;
using LoanworksBackend.Modules.Applications.Endpoints;
using LoanworksBackend.Modules.Applications.Endpoints.ApplicationBorrowers;
using LoanworksBackend.Modules.Applications.Endpoints.ApplicationLiabilities;
using LoanworksBackend.Modules.Applications.Endpoints.ApplicationLoans;
using LoanworksBackend.Modules.Applications.Endpoints.ApplicationProduct;
using LoanworksBackend.Modules.Applications.Endpoints.ApplicationSolicitors;
using LoanworksBackend.Modules.Applications.Endpoints.AppProductFunders;
using LoanworksBackend.Modules.Applications.Endpoints.Collateral_RealEstate;
using LoanworksBackend.Modules.Applications.Endpoints.Consultants;
using LoanworksBackend.Modules.Applications.Endpoints.FeeExceptions;
using LoanworksBackend.Modules.Applications.Endpoints.RestructuredLoanAmountDetails;

namespace LoanworksBackend.Modules.Applications;

/// <summary>
/// Registers module for Application related functionality
/// </summary>
public class ApplicationsModule : IModule
{
    /// <summary>
    /// Register services
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public IServiceCollection RegisterModules(IServiceCollection services)
    {
        return services;
    }
    /// <summary>
    /// Register API endpoints
    /// </summary>
    /// <param name="endpoints"></param>
    /// <returns></returns>
    public IEndpointRouteBuilder MapEndpoints(IEndpointRouteBuilder endpoints)
    {
        endpoints.MapPost("/applications/search", ApplicationSearchEndpoint.Handle)
            .WithTags("applications");
        endpoints.MapGet("/applications/{appId}", GetAppMainDetailsByAppIDEndPoint.Handle)
            .WithTags("applications");
        endpoints.MapGet("/applications/{appId}/summary", GetAppSummaryByAppIDEndPoint.Handle)
            .WithTags("applications");
        endpoints.MapGet("applications/{appId}/status", GetAppStatusByAppIDEndPoint.Handle)
            .WithTags("applications");

        //Application Product
        endpoints.MapGet("/applications/products/{appProductId}", GetAppProductByIDEndPoint.Handle)
            .WithTags("applications/products");
        endpoints.MapGet("/applications/{appId}/products", GetAppProductByAppIDEndPoint.Handle)
            .WithTags("applications/products");
        endpoints.MapGet("/applications/products/features", GetAppProductFeatureActiveEndPoint.Handle)
            .WithTags("applications/products");
        endpoints.MapGet("/applications/{appId}/products/fees", GetAppProductFeesEndPoint.Handle)
            .WithTags("applications/products");

        //Application Borrower
        endpoints.MapGet("/applications/{appId}/borrowers", GetAppBorrowerByAppIDEndPoint.Handle)
            .WithTags("applications/borrowers");
        endpoints.MapGet("/applications/borrowers/{borrowerId}", GetAppBorrowerByIDEndPoint.Handle)
            .WithTags("applications/borrowers");

        //Application Security
        endpoints.MapGet("/applications/{appId}/securities", GetAppSecurityByAppIDEndPoint.Handle)
            .WithTags("applications/securities");
        endpoints.MapGet("/applications/securities/{securityId}", GetAppSecurityByIDEndPoint.Handle)
            .WithTags("applications/securities");

        //Application Income
        endpoints.MapGet("/applications/income/{incomeId}", GetAppIncomeByIDEndPoint.Handle)
            .WithTags("applications/income");
        endpoints.MapGet("/applications/borrowers/{borrowerId}/income", GetAppIncomeByBorrowerIDEndPoint.Handle)
            .WithTags("applications/income");

        //Application Liabilities
        endpoints.MapGet("/applications/borrowers/liabilities/{liabilityId}", GetAppLiabilitiesByIDEndPoint.Handle)
           .WithTags("applications/liabilities");
        endpoints.MapGet("/applications/borrowers/{borrowerId}/liabilities", GetAppLiabilitiesByBorrowerIDEndPoint.Handle)
           .WithTags("applications/liabilities");
        endpoints.MapDelete("/applications/borrowers/liabilities/{liabilityId}", DeleteAppLiabilitiesEndPoint.Handle)
           .WithTags("applications/liabilities");

        //Application Loan
        endpoints.MapPost("/applications/application-loan", InsertApplicationLoanEndPoint.Handle)
            .WithTags("applications/application-loan");
        endpoints.MapDelete("/applications/application-loan", DeleteApplicationLoanEndPoint.Handle)
            .WithTags("applications/application-loan");

        //Collateral RealEstate
        endpoints.MapPost("/applications/collateral-realEstate", InsertCollateralRealEstateEndPoint.Handle)
            .WithTags("applications/collateral-realEstate");
        endpoints.MapPut("/applications/collateral-realEstate", UpdateCollateralRealEstateEndPoint.Handle)
            .WithTags("applications/collateral-realEstate");
        endpoints.MapGet("/applications/{appId}/collateral-realEstate", GetCollateralRealEstateByAppIDEndPoint.Handle)
            .WithTags("applications/collateral-realEstate");
        endpoints.MapDelete("/applications/collateral-realEstate", DeleteCollateralRealEstateEndPoint.Handle)
            .WithTags("applications/collateral-realEstate");

        //Application Solicitor 
        endpoints.MapGet("/applications/{appId}/solicitor", GetAppSolicitorByAppIDEndPoint.Handle)
            .WithTags("applications/solicitor");

        //Application Product Funder
        endpoints.MapGet("/applications/{appId}/funder", GetAppProductFundersByAppIDEndPoint.Handle)
            .WithTags("applications/product-funder");

        //Application Fee-Exceptions
        endpoints.MapGet("/applications/{appId}/fee-exceptions", GetFeeExceptionsByAppIDEndPoint.Handle)
            .WithTags("applications/fee-exceptions");

        //Application RestructuredLoanAmount Calculation Details
        endpoints.MapGet("/applications/{appId}/restructured-loan-info", GetAppRestructuredLoanAmountByAppIDEndPoint.Handle)
            .WithTags("applications/restructured-loan-info");

        //Application Consultants 
        endpoints.MapGet("/applications/{appId}/consultants", GetConsultantListUserByAppIDEndPoint.Handle)
            .WithTags("applications/consultants");

        return endpoints;
    }
}