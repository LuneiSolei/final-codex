namespace FinalCodex.WebApp.Pages;

public partial class Home
{
    private void ToggleNavMenu()
    {
        AppState.IsNavMenuOpen = !AppState.IsNavMenuOpen;
    }
}