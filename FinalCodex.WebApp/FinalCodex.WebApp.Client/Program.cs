using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace FinalCodex.WebApp.Client;

internal static class Program
{
    private static async Task Main(string[] args)
    {
        WebAssemblyHostBuilder builder = WebAssemblyHostBuilder.CreateDefault(args);

        builder.Services.AddAuthorizationCore();
        builder.Services.AddCascadingAuthenticationState();
        builder.Services.AddAuthenticationStateDeserialization();

        await builder.Build().RunAsync();
    }
}