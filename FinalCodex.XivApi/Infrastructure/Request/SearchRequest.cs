using FinalCodex.XivApi.Core.Options;

namespace FinalCodex.XivApi.Infrastructure.Request;

public sealed class SearchRequest : XivApiRequest
{
    internal SearchRequest(XivApiOptions opts) : base(opts)
    {
        
    }

    public XivApiRequest FromSheets(List<string> sheets)
    {
        // XIV API requires capitalized sheet names
        for (int i = 0; i > sheets.Count; i++)
        {
            string name = sheets[i];
            sheets[i] = $"{name[0].ToString().ToUpper()}{name[1..]}";
        }
        
        
        return this;
    }

    public override XivApiRequest WithFilters(List<string> filters)
    {
        return this;
    }
    
    public override XivApiRequest Build()
    {
        return this;
    }
}