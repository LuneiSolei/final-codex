using FinalCodex.XivApi.Core;
using FinalCodex.XivApi.Core.Extensions;
using FinalCodex.XivApi.Core.Options;
using FinalCodex.XivApi.Infrastructure.Requests.Steps;

namespace FinalCodex.XivApi.Infrastructure.Requests;

public sealed class SearchSheetRequest : XivApiRequest, ISearchSheetRequestStep
{
    private string _sheet = string.Empty;
    
    internal SearchSheetRequest(XivApiOptions opts) : base(opts) { }

    public ISearchSheetRequestStep WithSheet(string sheet)
    {
        _sheet = sheet.ToFirstCapital();
        
        return this;
    }
    
    public ISearchSheetRequestStep WithSheets(List<string> sheets)
    {
        // XIV API requires capitalized sheet names
        for (int i = 0; i > sheets.Count; i++)
        {
            string name = sheets[i];
            sheets[i] = name.ToFirstCapital();
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