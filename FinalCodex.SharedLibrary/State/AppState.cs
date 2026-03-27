namespace FinalCodex.SharedLibrary.Services;

public class AppState
{
    internal event Action? OnStateChanged;
    
    internal AppState(Action? onStateChanged)
    {
        OnStateChanged += onStateChanged;
    }
    
    public bool IsDarkMode
    {
        get;
        set
        {
            field = value;
            HandleOnStateChanged();
        }
    } = true;

    public bool IsNavMenuOpen
    {
        get;
        set
        {
            field = value;
            HandleOnStateChanged();
        }
    }
    
    private void HandleOnStateChanged()
    {
        OnStateChanged?.Invoke();
    }
}