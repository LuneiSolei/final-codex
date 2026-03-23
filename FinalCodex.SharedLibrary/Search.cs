using System.ComponentModel.DataAnnotations;

namespace FinalCodex.SharedLibrary;

public class Search
{
    // Prevent external instantiation
    internal Search() {}

    internal event Action? OnStateChanged;
    
    [Required(ErrorMessage = "No query entered")]
    [MinLength(1, ErrorMessage = "Query too short")]
    public string Query { get; set; } = "";

    public bool IsFiltersMenuOpen
    {
        get;
        set
        { 
            field = value;
            HandleOnStateChanged();
        }
    }

    public byte MinJobLvl = 0;
    public byte MaxJobLvl = 0;
    public ushort MinILvl = 0;
    public ushort MaxILvl = 0;
    
    private void HandleOnStateChanged()
    {
        OnStateChanged?.Invoke();
    }
}