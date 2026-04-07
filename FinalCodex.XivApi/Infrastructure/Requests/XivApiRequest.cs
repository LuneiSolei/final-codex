using FinalCodex.XivApi.Core.Options;

namespace FinalCodex.XivApi.Infrastructure.Requests;

public abstract class XivApiRequest
{
    protected string BaseUrl;
    protected List<string> queries = [];
    
    internal XivApiRequest(XivApiOptions opts)
    {
        BaseUrl = $"{opts.Scheme}://{opts.BaseUrl}/";
    }

    public virtual XivApiRequest WithFilters(List<string> filters) => this;
    
    public virtual XivApiRequest Build() => this;
}