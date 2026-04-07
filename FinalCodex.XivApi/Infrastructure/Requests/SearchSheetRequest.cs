using FinalCodex.XivApi.Core;
using FinalCodex.XivApi.Core.Enums;
using FinalCodex.XivApi.Core.Extensions;
using FinalCodex.XivApi.Core.Options;
using FinalCodex.XivApi.Infrastructure.Requests.Steps;

namespace FinalCodex.XivApi.Infrastructure.Requests;

public sealed class SearchSheetRequest : XivApiRequest, ISearchSheetRequestStep
{
    private List<string>? _sheets;
    private List<Clause>? _subQueryClauses;
    private string? _cursor;
    private uint? _limit;
    
    internal SearchSheetRequest(XivApiOptions opts) : base(opts) { }

    // Sheet(s)
    public ISearchSheetRequestStep WithSheet(string sheet)
    {
        _sheets?.Add(sheet.ToFirstCapital());
        
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

        _sheets ??= [];
        _sheets.AddRange(sheets);
        
        return this;
    }
    
    // Query
    public ISearchSheetRequestStep AddQueryClause(Clause clause)
    {
        _subQueryClauses ??= [];
        _subQueryClauses.Add(clause);
        
        return this;
    }

    public ISearchSheetRequestStep AddQueryClauses(List<Clause> clauses)
    {
        _subQueryClauses ??= [];
        _subQueryClauses.AddRange(clauses);
        
        return this;
    }

    // Parameters
    public ISearchSheetRequestStep WithVersion(string? version)
    {
        base.Version = version;

        return this;
    }

    public ISearchSheetRequestStep WithCursor(string? cursor)
    {
        _cursor = cursor;

        return this;
    }

    public ISearchSheetRequestStep WithLimit(uint limit)
    {
        _limit = limit;

        return this;
    }

    public ISearchSheetRequestStep WithLanguage(SchemaLanguage lang)
    {
        base.Language = lang;

        return this;
    }

    public ISearchSheetRequestStep WithSchema(string schemaSpecifier)
    {
        throw new NotImplementedException();
    }

    public ISearchSheetRequestStep WithFields(List<string> fields)
    {
        throw new NotImplementedException();
    }

    public ISearchSheetRequestStep WithTransient(string transient)
    {
        throw new NotImplementedException();
    }
}