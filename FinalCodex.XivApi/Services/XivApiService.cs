using FinalCodex.XivApi.Core.Options;
using FinalCodex.XivApi.Infrastructure.Requests;
using FinalCodex.XivApi.Infrastructure.Requests.Clauses;
using FinalCodex.XivApi.Infrastructure.Requests.Clauses.Steps;
using Microsoft.Extensions.Options;

namespace FinalCodex.XivApi.Services;

public class XivApiService(IOptions<XivApiOptions> opts, HttpClient _client)
{
    private readonly XivApiOptions _opts = opts.Value;

    public RequestBuilder NewRequestBuilder()
    {
        return new RequestBuilder(_opts);
    }

    public static IInitialClauseBuilderStep NewClause()
    {
        return new ClauseBuilder();
    }
}