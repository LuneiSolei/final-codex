using FinalCodex.SharedLibrary.Options;
using FinalCodex.SharedLibrary.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace XivApiTests;

public class Tests
{
    [Test]
    public void BindDefaultOptionsTest()
    {
        // Create an empty config to get default values
        IConfiguration config = new ConfigurationBuilder().Build();
        
        IServiceCollection services = new ServiceCollection();
        services.AddCodexService(config);
        ServiceProvider provider = services.BuildServiceProvider();
        CodexOptions libOpts = provider
            .GetRequiredService<IOptions<CodexOptions>>().Value;
        
        Assert.That(libOpts.XivApiOptions.BaseUrl,
            Is.EqualTo("https://v2.xivapi.com"));
    }
    
    [Test]
    public void BindCustomOptionsTest()
    {
        // Mimic a project's local config that overrides appsettings.json
        Dictionary<string, string?> testConfig = new()
        {
            ["CodexOptions:XivApiOptions:BaseUrl"] = "https://google.com"
        };
        IConfiguration config = new ConfigurationBuilder()
            .AddInMemoryCollection(testConfig).Build();
        
        IServiceCollection services = new ServiceCollection();
        services.AddCodexService(config);

        ServiceProvider provider = services.BuildServiceProvider();
        CodexOptions libOpts = provider
            .GetRequiredService<IOptions<CodexOptions>>().Value;
        
        Assert.That(libOpts.XivApiOptions.BaseUrl, 
            Is.EqualTo("https://google.com"));
    }
}