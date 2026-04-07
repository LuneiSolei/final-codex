using FinalCodex.XivApi.Core;
using FinalCodex.XivApi.Core.Enums;
using FinalCodex.XivApi.Core.Options;

namespace FinalCodex.XivApi.Infrastructure.Requests;

public abstract class XivApiRequest
{
    protected string BaseUrl;
    protected string? Version;
    protected SchemaLanguage? Language;
    protected List<Clause> QueryClauses = [];
    
    internal XivApiRequest(XivApiOptions opts)
    {
        BaseUrl = $"{opts.Scheme}://{opts.BaseUrl}/";
    }
}