namespace FinalCodex.WebApp.Components;

public partial class NavMenu : IDisposable
{
    protected override void OnInitialized()
    {
        base.OnInitialized();
        CodexService.OnStateChanged += StateHasChanged;
    }
    
    public void Dispose()
    {
        CodexService.OnStateChanged -= StateHasChanged;
        GC.SuppressFinalize(this);
    }
}