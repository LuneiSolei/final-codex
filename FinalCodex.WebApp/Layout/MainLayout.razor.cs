using Microsoft.AspNetCore.Components;

namespace FinalCodex.WebApp.Layout;

public partial class MainLayout : LayoutComponentBase, IDisposable
{
    protected override void OnInitialized()
    {
        base.OnInitialized();
        AppState.OnStateChanged += StateHasChanged;
    }

    public void Dispose() => AppState.OnStateChanged -= StateHasChanged;
}