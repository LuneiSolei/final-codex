using FinalCodex.XivApi.Core.Options;

namespace FinalCodex.XivApi.Infrastructure.Request;

public sealed class RequestBuilder
{
    private readonly XivApiOptions _opts;

    internal RequestBuilder(XivApiOptions opts)
    {
        _opts = opts;
    }

    public SearchRequest AsSearch()
    {
        return new SearchRequest(_opts);
    }

    public override string ToString() => "";
}