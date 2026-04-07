using FinalCodex.XivApi.Core.Options;
using FinalCodex.XivApi.Infrastructure.Requests.Steps;

namespace FinalCodex.XivApi.Infrastructure.Requests;

public sealed class RequestBuilder : IInitialRequestBuilderStep
{
    private readonly XivApiOptions _opts;

    internal RequestBuilder(XivApiOptions opts)
    {
        _opts = opts;
    }

    public ISearchSheetRequestStep AsSearch()
    {
        return new SearchSheetRequest(_opts);
    }

    public override string ToString() => "";
}