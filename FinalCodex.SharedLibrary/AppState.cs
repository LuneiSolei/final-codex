namespace FinalCodex.SharedLibrary;

public class AppState
{
    public AppState()
    {
        Search.OnStateChanged += NotifyOnStateChanged;
    }
    
    public Search Search = new();
    
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

    public event Action? OnStateChanged;
    
    private void NotifyOnStateChanged()
    {
        OnStateChanged?.Invoke();
    }
}