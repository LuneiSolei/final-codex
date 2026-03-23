using Microsoft.Extensions.Options;

namespace FinalCodex.SharedLibrary.Services;

public class SharedLibraryService(IOptions<Settings.SharedLibrarySettings> options)
{
    private readonly Settings.SharedLibrarySettings _sharedLibrarySettings = options.Value;
}