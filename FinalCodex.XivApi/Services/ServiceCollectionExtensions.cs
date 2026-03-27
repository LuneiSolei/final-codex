using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FinalCodex.XivApi.Services;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddXivApiService(
        this IServiceCollection services)
    {
        const string fileName = "FinalCodex.XivApi.appsettings.json";
        Assembly assembly = typeof(ServiceCollectionExtensions).Assembly;
        Stream stream = assembly.GetManifestResourceStream(
            name: fileName)
            ?? throw new FileNotFoundException($"'{fileName}' not found.");
        
        // Load default values from appsettings.json
        IConfiguration config = new ConfigurationBuilder()
            .AddJsonStream(stream)
            .Build();
        
        // Configure service with default options
        services.AddOptions<XivApiOptions>()
            .Bind(config.GetSection("XivApiOptions"));

        services.AddScoped<XivApiOptions>();

        return services;
    }
}