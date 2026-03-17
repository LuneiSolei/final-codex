namespace FinalCodex.Shared;

public class AppState
{
    public bool IsNavMenuOpen { get; set; }
    public bool IsDarkMode { get; set; } = true;
    public event Action? OnUpdate;

    public void ToggleNavMenu()
    {
        IsNavMenuOpen = !IsNavMenuOpen;
        OnUpdate?.Invoke();
    }
}