namespace FinalCodex.WebApp.Components;

public partial class ThemeModeToggle
{
    private string IconColor => AppState.IsDarkMode
        ? "theme-mode-toggle-dark"
        : "theme-mode-toggle-light";
}