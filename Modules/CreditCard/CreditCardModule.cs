using LoanworksBackend.Modules.CreditCard.Endpoint.Application;
using LoanworksBackend.Extensions;

namespace LoanworksBackend.Modules.Extracts;

/// <summary>
/// Registers module for Management related functionality
/// </summary>
public class CreditCardModule : IModule
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
        //Credit Card Application
        endpoints.MapGet("/credit-card/application", ListAllCreditCardApplicationEndpoint.Handle)
            .WithTags("credit-card/application");
        endpoints.MapPut("/credit-card/application/{id}", UpdateCreditCardApplicationEndpoint.Handle)
            .WithTags("credit-card/application");
        endpoints.MapGet("/credit-card/application/{id}", GetCreditCardApplicationEndpoint.Handle)
            .WithTags("credit-card/application");
        endpoints.MapPost("/credit-card/application", InsertCreditCardApplicationEndpoint.Handle)
            .WithTags("credit-card/application");
        endpoints.MapDelete("/credit-card/application/{id}", DeleteCreditCardApplicationEndpoint.Handle)
            .WithTags("credit-card/application");

        return endpoints;
    }
}