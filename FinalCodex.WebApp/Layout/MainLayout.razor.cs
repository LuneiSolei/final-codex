using Microsoft.AspNetCore.Components;

namespace FinalCodex.WebApp.Layout;

public partial class MainLayout : LayoutComponentBase, IDisposable
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