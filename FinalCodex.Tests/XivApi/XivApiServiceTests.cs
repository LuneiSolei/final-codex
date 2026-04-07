using FinalCodex.XivApi.Core;
using FinalCodex.XivApi.Core.Options;
using FinalCodex.XivApi.Infrastructure.Requests;
using FinalCodex.XivApi.Services;
using Microsoft.Extensions.DependencyInjection;

namespace XivApiTests.XivApi;

public class XivApiServiceTests
{
    // Configurable Variables
    private const string EqualToSpecifier = "Name";
    private const string EqualToValue = "Tank You, Paladin I";
    private const string EqualToSheet = "Achievement";
    private readonly string _equalToExpectedValue = 
        $"{EqualToSpecifier}={EqualToValue.Replace(" ", "+")}";
    
    // Storage Variables
    private readonly IServiceCollection _serviceCollection = new ServiceCollection();
    private ServiceProvider _provider;
    private XivApiService _service;
    private XivApiOptions _options;
    private readonly HttpClient _client = new();
    
    [OneTimeSetUp]
    public void Setup()
    {
        _serviceCollection.AddXivApiService();
        _provider = _serviceCollection.BuildServiceProvider();
        _service = _provider.GetRequiredService<XivApiService>();
        _options = _provider.GetRequiredService<XivApiOptions>();
    }

    [OneTimeTearDown]
    public void TearDown()
    {
        _provider.Dispose();
        _client.Dispose();
    }

    [Test]
    public void NewFilter_BuildsSingularClauseCorrectly()
    {
        Clause clause = XivApiService.NewClause()
            .WhereField(EqualToSpecifier)
            .Is()
            .EqualTo(EqualToValue);

        Assert.That(clause.ToString(), 
            Is.EqualTo(_equalToExpectedValue));
    }

    [Test]
    public void NewRequest_BuildsSearchRequestCorrectly()
    {
        Clause clause = XivApiService.NewClause()
            .WhereField(EqualToSpecifier)
            .Is()
            .EqualTo(EqualToValue);

        // XivApiRequest request = _service
        //     .NewRequestBuilder()
        //     .AsSearch()
        //     .FromSheets(["Achievement"])
        //     .WithFilters([clause])
        //     .Build();
    }
}