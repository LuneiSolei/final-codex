using FinalCodex.XivApi.Options;
using FinalCodex.XivApi.Query;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.Extensions.Options;

namespace FinalCodex.XivApi.Services;

public class XivApiService(IOptions<XivApiOptions> opts, HttpClient client)
{
    private readonly XivApiOptions _opts = opts.Value;
    private HttpClient _client = client;

    public void GetAchievement(string name)
    {
        SearchSheet("Achievement", name);
    }

    private void SearchSheet(string sheets, string name)
    {
        XivApiQueryBuilder xivQuery = new XivApiQueryBuilder()
            .Add(new XivApiQueryField("name", "en", "")
                .EqualTo(name));

        QueryBuilder query = new()
        {
            { "sheets", sheets },
            { "query", xivQuery.ToString() }
        };

        UriBuilder uri = new()
        {
            Host = _opts.BaseUrl,
            Path = _opts.Endpoints.Search,
            Query = query.ToString()
        };
        
        _client.GetAsync(uri.Uri);
    }
}