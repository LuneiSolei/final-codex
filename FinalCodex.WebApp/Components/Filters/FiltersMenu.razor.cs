namespace FinalCodex.WebApp.Components.Filters;

public partial class FiltersMenu : IDisposable
{
    protected override void OnInitialized()
    {
        base.OnInitialized();
        AppState.OnStateChanged += StateHasChanged;
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
        AppState.OnStateChanged -= StateHasChanged;
    }
}