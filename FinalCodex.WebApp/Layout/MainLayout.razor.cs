using Microsoft.AspNetCore.Components;

namespace FinalCodex.WebApp.Layout;

public partial class MainLayout : LayoutComponentBase, IDisposable
{
    public void Dispose()
    {
        AppState.OnStateChanged -= StateHasChanged;
        GC.SuppressFinalize(this);
    }

    protected override void OnInitialized()
    {
        base.OnInitialized();
        AppState.OnStateChanged += StateHasChanged;
    }

    private void ToggleNavMenu()
    {
        AppState.IsNavMenuOpen = !AppState.IsNavMenuOpen;
    }
}