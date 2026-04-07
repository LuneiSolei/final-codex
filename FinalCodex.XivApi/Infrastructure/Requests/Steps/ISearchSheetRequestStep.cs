using FinalCodex.XivApi.Core;
using FinalCodex.XivApi.Core.Enums;

namespace FinalCodex.XivApi.Infrastructure.Requests.Steps;

public interface ISearchSheetRequestStep
{
    // Sheets
    ISearchSheetRequestStep WithSheet(string sheet);
    ISearchSheetRequestStep WithSheets(List<string> sheets);
    
    // Query
    ISearchSheetRequestStep AddQueryClause(Clause clause);
    ISearchSheetRequestStep AddQueryClauses(List<Clause> clauses);
    
    // Parameters
    ISearchSheetRequestStep WithVersion(string version);
    ISearchSheetRequestStep WithCursor(string cursor);
    ISearchSheetRequestStep WithLimit(uint limit);
    ISearchSheetRequestStep WithLanguage(SchemaLanguage lang); 
    ISearchSheetRequestStep WithSchema(string schemaSpecifier);
    ISearchSheetRequestStep WithFields(List<string> fields);
    ISearchSheetRequestStep WithTransient(string transient);
    
    /*
     * TODO: Define SchemaLanguage, SchemaSpecifier, and FilterString as used
     * by XIV API
    */
}