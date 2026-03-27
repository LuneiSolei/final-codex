using System.ComponentModel.DataAnnotations;

namespace FinalCodex.SharedLibrary.Options;

public class XivApiOptions
{
    [Required] public string? BaseUrl { get; set; }
}