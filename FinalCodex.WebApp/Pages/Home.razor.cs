namespace FinalCodex.WebApp.Pages;

public partial class Home
{
    private void ToggleNavMenu()
    {
        CodexService.AppState.IsNavMenuOpen = !CodexService.AppState.IsNavMenuOpen;
    }
}