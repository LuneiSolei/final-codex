namespace FinalCodex.WebApp.Components.Filters;

public partial class FiltersMenu : IDisposable
{
    protected override void OnInitialized()
    {
        base.OnInitialized();
        CodexService.OnStateChanged += StateHasChanged;
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
        CodexService.OnStateChanged -= StateHasChanged;
    }
}