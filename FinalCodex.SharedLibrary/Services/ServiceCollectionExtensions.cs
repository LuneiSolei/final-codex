using System.Reflection;
using FinalCodex.SharedLibrary.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FinalCodex.SharedLibrary.Services;

public static class ServiceCollectionExtensions 
{
    public static IServiceCollection AddSharedLibraryService(
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
        services.AddOptions<SharedLibraryOptions>()
            .Bind(defaultConfig.GetSection("SharedLibraryOptions")) // Library defaults
            .Bind(userConfig.GetSection("SharedLibraryOptions"));    // User overrides

        return services;
    }
}