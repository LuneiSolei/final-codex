namespace FinalCodex.XivApi.Infrastructure.Requests.Steps;

public interface ISearchSheetRequestStep
{
    ISearchSheetRequestStep WithSheet(string sheet);
    ISearchSheetRequestStep WithSheets(List<string> sheets);
}