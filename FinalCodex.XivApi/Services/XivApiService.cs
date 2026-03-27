using Microsoft.Extensions.Options;

namespace FinalCodex.XivApi.Services;

public class XivApiService(IOptions<XivApiOptions> opts)
{
    private readonly XivApiOptions _opts = opts.Value;

    public void GetItem()
    {
        
    }
}