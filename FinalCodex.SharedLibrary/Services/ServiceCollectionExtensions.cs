using System.Reflection;
using FinalCodex.SharedLibrary.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FinalCodex.SharedLibrary.Services;

public static class ServiceCollectionExtensions 
{
    public static IServiceCollection AddCodexService(
        this IServiceCollection services,
        IConfiguration userConfig)
    {
        Assembly assembly = typeof(ServiceCollectionExtensions).Assembly;
        Stream stream = assembly.GetManifestResourceStream(
                name: "FinalCodex.SharedLibrary.appsettings.json") 
                ?? throw new FileNotFoundException();
        
        // Load default values from appsettings.json embedded in our library
        IConfiguration defaultConfig = new ConfigurationBuilder()
            .AddJsonStream(stream)
            .Build();
        
        // Configure service with default options
        services.AddOptions<CodexOptions>()
            .Bind(defaultConfig.GetSection("CodexOptions")) // Library defaults
            .Bind(userConfig.GetSection("CodexOptions"));   // User overrides

        services.AddScoped<CodexOptions>();

        return services;
    }
}