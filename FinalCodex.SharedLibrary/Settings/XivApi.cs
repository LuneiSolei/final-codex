using System.ComponentModel.DataAnnotations;

namespace FinalCodex.SharedLibrary.Settings;

public class XivApi
{
    [Required] public string BaseApiUrl { get; set; }
}