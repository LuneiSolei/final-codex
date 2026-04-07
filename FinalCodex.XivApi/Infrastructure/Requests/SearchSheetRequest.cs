using FinalCodex.XivApi.Core;
using FinalCodex.XivApi.Core.Enums;
using FinalCodex.XivApi.Core.Extensions;
using FinalCodex.XivApi.Core.Options;
using FinalCodex.XivApi.Infrastructure.Requests.Steps;

namespace FinalCodex.XivApi.Infrastructure.Requests;

public sealed class SearchSheetRequest : XivApiRequest, ISearchSheetRequestStep
{
    private List<string>? _sheets;
    private List<Clause>? _queryClauses;
    private string? _cursor;
    private uint? _limit;
    
    internal SearchSheetRequest(XivApiOptions opts) : base(opts) { }

    // Sheet(s)
    /// <summary>
    /// Name of the Excel sheet that the query should be run against.
    /// </summary>
    /// <remarks>At least one must be specified if not querying a cursor.</remarks>
    /// <seealso cref="WithSheets"/>
    /// <param name="sheet">Name of the Excel sheet.</param>
    public ISearchSheetRequestStep WithSheet(string sheet)
    {
        _sheets?.Add(sheet.ToFirstCapital());
        
        return this;
    }
    
    /// <summary>
    /// List of names of Excel sheets that the query should be run against.
    /// </summary>
    /// <remarks>At least one must be specified if not querying a cursor.</remarks>
    /// <param name="sheets"></param>
    /// <seealso cref="WithSheet"/>
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
    /// <summary>
    /// 
    /// </summary>
    /// <param name="clause"></param>
    /// <returns></returns>
    public ISearchSheetRequestStep AddQueryClause(Clause clause)
    {
        _queryClauses ??= [];
        _queryClauses.Add(clause);
        
        return this;
    }

    public ISearchSheetRequestStep AddQueryClauses(List<Clause> clauses)
    {
        _queryClauses ??= [];
        _queryClauses.AddRange(clauses);
        
        return this;
    }

    // Parameters
    public ISearchSheetRequestStep WithVersion(string? version)
    {
        base.Version = version;

        return this;
    }

    public ISearchSheetRequestStep WithLanguage(SchemaLanguage language)
    {
        base.Language = language;
        
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

    public string Build()
    {
        string query = string.Empty;
        
        if (_sheets is not null)
        {
            query += BuildSheetsParam();
        }
        else
        {
            query += BuildCursor();
        }
        
        string url = $"{BaseUrl}{Options.Endpoints.Search}?{query}";

        return url;
    }

    private string BuildSheetsParam() =>
        _sheets is null ? string.Empty : string.Join(",", _sheets);

    private string BuildSubQuery()
    {
        
    }

    private string BuildCursor()
    {
        
    }
}