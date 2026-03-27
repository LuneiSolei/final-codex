using FinalCodex.SharedLibrary.Services;
using Microsoft.AspNetCore.Components;

namespace FinalCodex.WebApp.Layout;

public partial class MainLayout : LayoutComponentBase, IDisposable
{
    public void Dispose()
    {
        CodexService.OnStateChanged -= StateHasChanged;
        GC.SuppressFinalize(this);
    }

    protected override void OnInitialized()
    {
        base.OnInitialized();
        CodexService.OnStateChanged += StateHasChanged;
    }

    private void ToggleNavMenu()
    {
        CodexService.AppState.IsNavMenuOpen = !CodexService.AppState.IsNavMenuOpen;
    }
}