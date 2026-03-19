namespace FinalCodex.Shared;

public class AppState
{
    
    public event Action? OnStateChanged;

    public bool IsDarkMode
    {
        get;
        set
        {
            field = value;
            NotifyOnStateChanged();
        }
    } = true;

    public bool IsNavMenuOpen
    {
        get;
        set
        {
            field = value;
            NotifyOnStateChanged();
        }
    }
    
    public void ToggleNavMenu() { IsNavMenuOpen = !IsNavMenuOpen; }

    private void NotifyOnStateChanged() => OnStateChanged?.Invoke();
}