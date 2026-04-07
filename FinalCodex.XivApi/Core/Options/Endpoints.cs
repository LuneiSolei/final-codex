using System.ComponentModel.DataAnnotations;

namespace FinalCodex.XivApi.Core.Options;

public class Endpoints
{
    [Required]
    public required string Search { get; set; }
}