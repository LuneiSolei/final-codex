using System.Diagnostics;
using System.Reflection;
using FinalCodex.SharedLibrary.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FinalCodex.SharedLibrary.Services;

public static class ServiceCollectionExtensions 
{
    public static IServiceCollection AddSharedLibrary(
        this IServiceCollection services, IConfiguration configuration)
    {
        // Get assembly (.dll) for the shared library
        Assembly assembly = Assembly.GetExecutingAssembly();
        
        string resourceName = "SharedLibrary.appsettings.json";
        using Stream? stream = assembly.GetManifestResourceStream(resourceName);
        Debug.Assert(stream != null, nameof(stream) + " != null");
        
        // Build a local IConfiguration with priority order from lowest to 
        // highest
        IConfiguration libraryConfig = new ConfigurationBuilder()
            .AddJsonStream(stream)
            .AddConfiguration(configuration)
            .Build();

        // Bind our librarySettings section of appsettings.json to our
        // SharedLibrarySettings class
        services.AddOptionsWithValidateOnStart<SharedLibrarySettings>()
            .Bind(libraryConfig);
        
        services.AddScoped<SharedLibraryService>();

        return services;
    }
}