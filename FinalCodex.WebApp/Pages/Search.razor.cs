using MudBlazor;

namespace FinalCodex.WebApp.Pages;

public partial class Search : IDisposable
{
    public required MudForm Form { get; set; }

    private void ToggleSearchFilters()
    {
        AppState.Search.IsFiltersMenuOpen =
            !AppState.Search.IsFiltersMenuOpen;
    }

    private string GetFilterIcon()
    {
        return AppState.Search.IsFiltersMenuOpen
            ? Icons.Material.Filled.FilterAlt
            : Icons.Material.TwoTone.FilterAlt;
    }

    private async Task Submit()
    {
        await Form.ValidateAsync();

        if (Form.IsValid)
        {
            Console.WriteLine("Is valid!");
        }
    }

    protected override void OnInitialized()
    {
        base.OnInitialized();
        AppState.OnStateChanged += StateHasChanged;
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
        AppState.OnStateChanged -= StateHasChanged;
    }
}