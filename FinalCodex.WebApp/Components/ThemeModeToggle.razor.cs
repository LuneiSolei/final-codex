using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace FinalCodex.WebApp.Components;

public partial class ThemeModeToggle : ComponentBase
{
    private string ThemeIcon => AppState.IsDarkMode ? Icons.Material.Filled.DarkMode : Icons.Material.Filled.LightMode;
}