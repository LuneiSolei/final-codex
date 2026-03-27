using FinalCodex.SharedLibrary.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

namespace FinalCodex.WebApp;

public static class Program
{
    public static async Task Main(string[] args)
    {
        WebAssemblyHostBuilder builder = WebAssemblyHostBuilder.CreateDefault(args);
        builder.RootComponents.Add<App>("#app");
        builder.RootComponents.Add<HeadOutlet>("head::after");

        builder.Services.AddScoped(_ => new HttpClient
            { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
        builder.Services.AddMudServices();
        
        builder.Services.AddCodexService(builder.Configuration);

        await builder.Build().RunAsync();
    }
}