using FinalCodex.XivApi.Core.Options;
using FinalCodex.XivApi.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace XivApiTests.XivApi;

public class Tests
{
    [Test]
    public void BindDefaultXivApiOptionsTest()
    {
        IServiceCollection services = new ServiceCollection();
        services.AddXivApiService();
        ServiceProvider provider = services.BuildServiceProvider();
        XivApiOptions libOpts = provider
            .GetRequiredService<IOptions<XivApiOptions>>().Value;
        
        Assert.That(libOpts.BaseUrl,
            Is.EqualTo("v2.xivapi.com"));
    }
    
    // [Test]
    // public void BindCustomOptionsTest()
    // {
    //     // Mimic a project's local config that overrides appsettings.json
    //     Dictionary<string, string?> testConfig = new()
    //     {
    //         ["CodexOptions:XivApiOptions:BaseUrl"] = "https://google.com"
    //     };
    //     IConfiguration config = new ConfigurationBuilder()
    //         .AddInMemoryCollection(testConfig).Build();
    //     
    //     IServiceCollection services = new ServiceCollection();
    //     services.AddXivApi(config);
    //
    //     ServiceProvider provider = services.BuildServiceProvider();
    //     CodexOptions libOpts = provider
    //         .GetRequiredService<IOptions<CodexOptions>>().Value;
    //     
    //     Assert.That(libOpts.XivApiOptions.BaseUrl, 
    //         Is.EqualTo("https://google.com"));
    // }
}