using FinalCodex.SharedLibrary.Services;
using MudBlazor;

namespace FinalCodex.WebApp.Pages;

public partial class Search : IDisposable
{
    public required MudForm Form { get; set; }

    private void ToggleSearchFilters()
    {
        CodexService.SearchState.IsFiltersMenuOpen =
            !CodexService.SearchState.IsFiltersMenuOpen;
    }

    private string GetFilterIcon()
    {
        return CodexService.SearchState.IsFiltersMenuOpen
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
        CodexService.OnStateChanged += StateHasChanged;
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
        CodexService.OnStateChanged -= StateHasChanged;
    }
}