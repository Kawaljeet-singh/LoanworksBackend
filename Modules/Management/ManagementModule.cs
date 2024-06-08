using LoanworksBackend.Modules.Management.Endpoint.Management;
using LoanworksBackend.Extensions;

namespace LoanworksBackend.Modules.Extracts;

/// <summary>
/// Registers module for Management related functionality
/// </summary>
public class ManagementModule : IModule
{
    /// <summary>
    /// Register services
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public IServiceCollection RegisterModules(IServiceCollection services)
    {
        //services.AddScoped<IExportWorkflowService, ExportWorkflowService>();
        //services.AddScoped<IExportProductsService, ExportProductsService>();
        //services.AddScoped<IExportUserSecurityService, ExportUserSecurityService>();
        //services.AddSingleton(typeof(IExcelService<>), typeof(ExcelService<>));

        return services;
    }

    /// <summary>
    /// Register API endpoints
    /// </summary>
    /// <param name="endpoints"></param>
    /// <returns></returns>
    public IEndpointRouteBuilder MapEndpoints(IEndpointRouteBuilder endpoints)
    {
        //Application Class
        endpoints.MapGet("/management/application-class", ListAllApplicationClassEndpoint.Handle)
            .WithTags("management/application-class");
        endpoints.MapPut("/management/application-class/{id}", UpdateApplicationClassEndpoint.Handle)
            .WithTags("management/application-class");
        endpoints.MapGet("/management/application-class/{id}", GetApplicationClassEndpoint.Handle)
            .WithTags("management/application-class");
        endpoints.MapPost("/management/application-class", InsertApplicationClassEndpoint.Handle)
            .WithTags("management/application-class");
        endpoints.MapDelete("/management/application-class/{id}", DeleteApplicationClassEndpoint.Handle)
            .WithTags("management/application-class");

        //Application Loan Class
        endpoints.MapGet("/management/application-loan-class/{applicationClassId}", GetApplicationLoanClassEndpoint.Handle)
            .WithTags("management/application-loan-class");
        endpoints.MapPost("/management/application-loan-class", InsertApplicationLoanClassEndpoint.Handle)
            .WithTags("management/application-loan-class");
        endpoints.MapDelete("/management/application-loan-class/{applicationClassId}", DeleteApplicationLoanClassEndpoint.Handle)
            .WithTags("management/application-loan-class");

        //Application Class Application Type
        endpoints.MapGet("/management/application-types/{id}", GetApplicationTypesEndpoint.Handle)
            .WithTags("management/application-types");
        endpoints.MapPost("/management/application-types", InsertApplicationTypesEndpoint.Handle)
            .WithTags("management/application-types");
        endpoints.MapDelete("/management/application-types/{id}", DeleteApplicationTypesEndpoint.Handle)
            .WithTags("management/application-types");

        //Application Collateral Class
        endpoints.MapGet("/management/application-class/collateral-class", ListAllApplicationCollateralClass.Handle)
            .WithTags("management/application-class");
        endpoints.MapGet("/management/application-class/collateral-class/{id}", GetApplicationCollateralClass.Handle)
            .WithTags("management/application-class");
        endpoints.MapPost("/management/application-class/collateral-class", InsertApplicationCollateralClass.Handle)
            .WithTags("management/application-class");
        endpoints.MapDelete("/management/application-class/collateral-class/{id}", DeleteApplicationCollateralClass.Handle)
            .WithTags("management/application-class");

        return endpoints;
    }
}