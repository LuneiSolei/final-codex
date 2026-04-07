namespace FinalCodex.XivApi.Infrastructure.Requests.Steps;

public interface IInitialRequestBuilderStep
{
    ISearchSheetRequestStep AsSearch();
}