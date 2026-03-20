namespace FinalCodex.WebApp.Components;

public partial class NavMenu : IDisposable
{
    public void Dispose()
    {
        AppState.OnStateChanged -= StateHasChanged;
    }

    protected override void OnInitialized()
    {
        base.OnInitialized();
        AppState.OnStateChanged += StateHasChanged;
    }
}