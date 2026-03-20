using Microsoft.AspNetCore.Components;

namespace FinalCodex.WebApp.Components;

public partial class ThemeModeToggle : ComponentBase
{
    private string IconColor => AppState.IsDarkMode
        ? "theme-mode-toggle-dark"
        : "theme-mode-toggle-light";
}