using FinalCodex.SharedLibrary.Options;
using FinalCodex.SharedLibrary.State;
using FinalCodex.SharedLibrary.State.Search;
using Microsoft.Extensions.Options;

namespace FinalCodex.SharedLibrary.Services;

public class CodexService
{
    public AppState AppState { get; }
    public SearchState SearchState { get; }
    public event Action? OnStateChanged;
    private readonly CodexOptions _libOpts;
    
    public CodexService(IOptions<CodexOptions> opts)
    {
        _libOpts = opts.Value;
        SearchState = new SearchState(OnStateChanged);
        AppState = new AppState(OnStateChanged);
    }

    public void GetXivApiItems()
    {
        
    }
}