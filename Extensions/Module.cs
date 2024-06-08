namespace LoanworksBackend.Extensions;

/// <summary>
/// Defines the contract for a module declaration. Modules allow us to group common domains into same folder structure
/// for consistancy. This defines how to setup the modules and allows additional modules to be easily added in future.
/// </summary>
public interface IModule
{
    IServiceCollection RegisterModules(IServiceCollection builder);
    IEndpointRouteBuilder MapEndpoints(IEndpointRouteBuilder endpoints);
}

public static class ModuleExtensions
{
    static readonly List<IModule> registeredModules = new();

    /// <summary>
    /// Hooks up the DI services required
    /// </summary>
    /// <param name="builder"></param>
    /// <returns></returns>
    public static WebApplicationBuilder RegisterModules(this WebApplicationBuilder builder)
    {
        var modules = DiscoverModules();
        foreach (var module in modules)
        {
            module.RegisterModules(builder.Services);
            registeredModules.Add(module);
        }

        return builder;
    }

    /// <summary>
    /// Hooks up the endpoint config for each module
    /// </summary>
    /// <param name="app"></param>
    /// <returns></returns>
    public static WebApplication MapEndpoints(this WebApplication app)
    {
        foreach (var module in registeredModules)
        {
            module.MapEndpoints(app);
        }

        return app;
    }

    /// <summary>
    /// Reflect all the available modules in this app
    /// </summary>
    /// <returns></returns>
    private static IEnumerable<IModule> DiscoverModules()
    {
        return typeof(IModule).Assembly
            .GetTypes()
            .Where(p => p.IsClass && p.IsAssignableTo(typeof(IModule)))
            .Select(Activator.CreateInstance)
            .Cast<IModule>();
    }
}
