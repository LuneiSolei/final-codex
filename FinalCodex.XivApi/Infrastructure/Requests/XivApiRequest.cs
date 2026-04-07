using FinalCodex.XivApi.Core;
using FinalCodex.XivApi.Core.Enums;
using FinalCodex.XivApi.Core.Options;

namespace FinalCodex.XivApi.Infrastructure.Requests;

public abstract class XivApiRequest
{
    protected string BaseUrl;
    protected XivApiOptions Options;
    protected string? Version;
    protected SchemaLanguage? Language;
    protected string? Schema;
    protected List<Clause> QueryClauses = [];
    
    internal XivApiRequest(XivApiOptions opts)
    {
        Options = opts;
        BaseUrl = $"{opts.Scheme}://{opts.BaseUrl}/";
    }
}