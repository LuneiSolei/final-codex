using FinalCodex.SharedLibrary.Options;
using FinalCodex.SharedLibrary.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace XivApiTests;

public class Tests
{
    [Test]
    public void BindOptionsTest()
    {
        // Mimic a project's local config that overrides appsettings.json
        Dictionary<string, string?> testConfig = new()
        {
            ["SharedLibraryOptions:XivApiOptions:BaseApiUrl"] = "https://google.com"
        };
        IConfiguration config = new ConfigurationBuilder()
            .AddInMemoryCollection(testConfig).Build();

        IServiceCollection services = new ServiceCollection();
        services.AddSharedLibraryService(config);

        ServiceProvider provider = services.BuildServiceProvider();
        SharedLibraryOptions sharedLibraryOptions = provider
            .GetRequiredService<IOptions<SharedLibraryOptions>>().Value;
        
        Assert.That(sharedLibraryOptions.XivApiOptions.BaseApiUrl, 
            Is.EqualTo("https://google.com"));
    }
}